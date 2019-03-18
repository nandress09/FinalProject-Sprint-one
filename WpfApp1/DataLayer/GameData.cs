using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.DataLayer
{
    class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Jerry",
                Age = 43,
                JobTitle = Player.JobTitleName.Explorer,
                Race = Character.RaceType.Thorian,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "\t You have only five chances to find the evidence to prove your innocence.. get to work.",
                "\t That's all changed. The local community is furious, as their top breeder sheep has been murdered.. You're their suspect",
                "\t As a predator of the forest, you're generally left alone",
            };
        }

       
    }
}
