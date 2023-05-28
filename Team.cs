using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(Coach coach)
        {
            Coach = coach;
            Players = new List<FootballPlayer>();
        }

        public void AddPlayer(List<FootballPlayer> player)
        {
            
        }

        public double GetAverageAge()
        {
            if (Players.Count == 0)
                return 0;

            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Count;
        }

    }

   
}
