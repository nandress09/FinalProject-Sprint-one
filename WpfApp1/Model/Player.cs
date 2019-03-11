using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Player : Character
    {
        public enum JobTitleName { Wolf, Racoon, Bear}

        private int _lives;
        private int _health;
        private int _experiencePoints;
        private JobTitleName _jobTitle;

        public JobTitleName JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }


        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }


        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public override string DefaultGreeting()
        {
            string article = "a";

            List<string> vowels = new List<string>() {"A", "E","I", "O","U" };

            if (vowels.Contains(_jobTitle.ToString().Substring(0,1)));
            {
                article = "an";
            }
            return $"Hello, my name is {_name}, and I am {article} {_jobTitle}";
        }

        
    }
}
