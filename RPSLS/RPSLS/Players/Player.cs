using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSLS.Gestures;

namespace RPSLS.Players
{
    abstract class Player
    {
        public Gesture[] gestures;
        public Gesture gestureChoice;
        public string name;
        public int score;

        public Player(string name)
        {
            gestures = new Gesture[] { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
            gestureChoice = new Rock();
            this.name = name;
            score = 0;
        }

        public void PrintGestures()
        {
            Console.WriteLine("\nOptions:");
            foreach (Gesture gesture in gestures)
            {
                Console.WriteLine(gesture.name);
            }
        }

        public virtual void ChooseGesture()
        {

        }

        public virtual void SetName()
        {

        }

    }

}
