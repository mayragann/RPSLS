using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSLS.Gestures;

namespace RPSLS.Players
{
    internal class Human : Player
    {
        public Human(string name) : base(name)
        {
            this.name = name;
        }

        public void SetName()
        {
            Console.WriteLine($"{name}, please enter your name.");
            this.name = Console.ReadLine();
        }

        public void ChooseGesture()
        {
            bool validChoice = false;
            while (!validChoice)
            {
                PrintGestures();
                Console.WriteLine($"\n{name}, choose an option:");
                string input = Console.ReadLine();

                foreach (Gesture gesture in gestures)
                {
                    if (input == gesture.name)
                    {
                        gestureChoice = gesture;
                        validChoice = true;
                        break;
                    }
                }
            }
        }
    }
}
