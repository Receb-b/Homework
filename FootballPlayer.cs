using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public int Height { get; set; }
        public FootballPlayer(int number, int height, string name, int age) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
