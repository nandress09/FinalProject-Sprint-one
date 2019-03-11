using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
//
//
//
//         Greeting: This is my Predator Game
//         Nicole Andress
//         3/10/2019
//         Sprint one: The Wolf
//         Goals: begin to morph the game 
//
//
namespace WpfApp1.PresentationLayer
{
    public class GameSessionViewModel
    {
        private List<string> _messages;
        private DateTime _gameStartTime;
        private Player _player;
       

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel (
            Player player, 
            List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
            InitializeView();
        }

        private void InitializeView()
        {
            _gameStartTime = DateTime.Now;
        }

        private string FormatMessagesForViewer()
        {
            List<string> lifeMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifeMessages.Add($" <T:{GameTime().ToString(@"hh\:mm\:ss")} " + _messages[index]);
            }

            lifeMessages.Reverse();

            return string.Join("\n\n", lifeMessages);
        }

        private TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }


    }
}
