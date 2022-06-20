namespace RPSLS.Gestures
{
    internal class Lizard : Gesture
    {

        public Lizard()
        {
            this.name = "lizard";
            this.loses_to = new string[] { "rock", "scissors" };
            this.wins_against = new string[] { "paper", "spock" };
        }
    }
}