using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Location
    {
        //set photo to a room 
        //public enum Room
        //{
        //    church,
        //    room1,
        //    room2,
        //    room3,
        //    room4
        //}

        //public class ListRoomModel
        //{
        //    public ObserveRoom<Room> ExploreRoom { get; private set; }
        //    public ListRoomModel()
        //    {
        //        ExploreRoom = new ObserveRoom<Rooms>
        //        {
        //            Room.church,
        //            Room.room1,
        //            Room.room2,
        //            Room.room3,
        //            Room.room4
        //        };

        //    }
        //}

        private int _id;
        private string _name;
        private string _roomDescription;
        private int _investigate;


        public int Investigate
        {
            get { return _investigate; }
            set { _investigate = value; }
        }


        public string RoomDescription
        {
            get { return _roomDescription; }
            set { _roomDescription = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
    }
}
