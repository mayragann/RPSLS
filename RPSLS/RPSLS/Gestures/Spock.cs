namespace RPSLS.Gestures
{
    internal class Spock : Gesture
    {
        public Spock()
        {
            this.name = "spock";
            this.loses_to = new string[] { "paper", "lizard" };
            this.wins_against = new string[] { "rock", "scissors" };
        }
    }
}
