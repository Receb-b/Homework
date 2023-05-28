using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public int AssistantRefereeCount { get; set; }
        public List<Goal> Goals { get; set; }

        public Game(Team team1, Team team2, Referee referee, int assistantRefereeCount)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantRefereeCount = assistantRefereeCount;
            Goals = new List<Goal>();
        }

        public void Start()
        {
            Console.WriteLine("The game has started!");

            Random random = new Random();

            for (int minute = 1; minute <= 90; minute++)
            {
                if (random.Next(1, 11) <= 1)
                {
                    int playerIndex = random.Next(0, Team1.Players.Count);
                    FootballPlayer scorer = Team1.Players[playerIndex];

                    Goal goal = new Goal(minute, scorer);
                    Goals.Add(goal);

                    Console.WriteLine($"Goal scored at minute {minute} by {scorer.Name} from Team 1!");
                }
            }

            Console.WriteLine("The game has ended!");
        }

        public string GetResult()
        {
            int team1Goals = Goals.Count;
            int team2Goals = 0;

            return (team1Goals > team2Goals) ? "Team 1 wins" : "Team 2 wins";
        }
    }
}
