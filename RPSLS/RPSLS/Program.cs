using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Would You like To Play Rock Paper Scissors Lizard Spock? Type y for yes and n for no: ");
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "y":
                    Game NewGame = new Game();
                    NewGame.RunGame();
                    break;
                case "n";
                    break;
            }
            Console.Read();
        }
    } }