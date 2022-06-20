namespace RPSLS.Gestures
{
    internal class Rock : Gesture
    {
        public Rock()
        {
            this.name = "rock";
            this.loses_to = new string[] { "paper", "spock" };
            this.wins_against = new string[] { "lizard", "scissors" };
        }
    }
}
