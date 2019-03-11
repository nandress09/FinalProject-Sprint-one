using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.PresentationLayer;
using WpfApp1.DataLayer;
using WpfApp1.Model;

namespace WpfApp1.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        bool _newPlayer = true;
        Player _player;
        PlayerSetupView _playerSetupView;


        public GameBusiness()
        {
            SetupPlayer();
            InstantiateAndShowView();
        }

        public void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

                _player.ExperiencePoints = 0;
                _player.Health = 100;
                _player.Lives = 3;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        private void InstantiateAndShowView()
        {

            _gameSessionViewModel = new GameSessionViewModel(_player, GameData.InitialMessages());

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

        }


    }

}
