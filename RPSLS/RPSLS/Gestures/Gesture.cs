using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    abstract class Gesture
    {
        public string name;
        public string[] loses_to;
        public string[] wins_against;
    }
}
