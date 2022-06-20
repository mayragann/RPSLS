using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        public Computer()
            {
                name="Eye";
            }
        public override void ChooseOption()
        {
            Random random = new Random();
            List<string> choices = new List<string> {"Rock", "Paper", "Scissors", "Lizard", "Spock" };
            choice = choices[random.Next(0, 4)];
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{choice}");
            Console.WriteLine($"{name} Picked {choice}");
        }
    }
}
