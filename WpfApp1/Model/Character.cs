using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Character
    {
        public enum RaceType
        {
            Nuetral,
            Kind,
            Evil
        }

        protected int _id;
        protected string _name;
        protected int _locationId;
        protected int _age;
        protected RaceType _race;


        public RaceType Race
        {
            get { return _race; }
            set { _race = value; }
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
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

        public virtual string DefaultGreeting()
        {
            return $"Hello,my name is {_name} and I am a {_race}";
        }

    }
}
