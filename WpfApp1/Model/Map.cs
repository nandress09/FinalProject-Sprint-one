using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class Map
    {
        private Location[,] _mapLocations;
        private int _maxRows;
        private int _maxColumns;

        private GameMapCoordinates _currentLocationCoordinates;


        public GameMapCoordinates CurrentLocationCoordinates
        {
            get { return _currentLocationCoordinates; }
            set { _currentLocationCoordinates = value; }
        }

        public Location CurrentLocation
        {
            get { return _mapLocations[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column]; }
        }


        public Location[,] MapLocations
        {
            get { return _mapLocations; }
            set { _mapLocations = value; }
        }

        public void Church()
        {
            if (_currentLocationCoordinates.Row > 0)
            {
                _currentLocationCoordinates.Row -= 1;
            }
        }
        public void Room1()
        {
            if (_currentLocationCoordinates.Column < _maxColumns -1) 
            {
                _currentLocationCoordinates.Column += 1;
            }
        }
        public void Room2()
        {
            if (_currentLocationCoordinates.Row < _maxRows - 1)
            {
                _currentLocationCoordinates.Row += 1;
            }
        }
        public void Room3()
        {
            if (_currentLocationCoordinates.Row > 0)
            {
                _currentLocationCoordinates.Row -= 1;
            }
        }



    }
}
