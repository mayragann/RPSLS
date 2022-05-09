
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public string choice;
        public Random AirRandomOption = new Random();

        public Player()
        { 
        
        }
        public void GetPlayerName()
        {
            Console.Write("\nPlease Enter Player Name: ");
            name = (Console.ReadLine());
        }

        public virtual void ChooseOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{name} Choose Your Option: \n Rock, Paper, Scissors, Lizard, or Spock");
            choice = (Console.ReadLine());
            switch (choice)
            {
                case "Rock":
                    Console.WriteLine($"\n{name} Choose Rock");
                    break;
                case "Paper":
                    Console.WriteLine($"\n{name} Choose Paper");
                    break;
                case "Scissors":
                    Console.WriteLine($"\n{name} Choose Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine($"\n{name} Choose Lizardk");
                    break;
                case "Spock":
                    Console.WriteLine($"\n{name} Choose Spock");
                    break;
                default:
                    Console.WriteLine($"\n{name}, PICK THE CORRECT OPTION");
                    break;
            }
        }
    }
}