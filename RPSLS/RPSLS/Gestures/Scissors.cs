namespace RPSLS.Gestures
{
    internal class Scissors : Gesture
    {
        public Scissors()
        {
            this.name = "scissors";
            this.loses_to = new string[] { "rock", "spock" };
            this.wins_against = new string[] { "paper", "lizard" };
        }
    }
}