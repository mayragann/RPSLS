namespace RPSLS.Gestures
{
    internal class Paper : Gesture
    {

        public Paper()
        {
            this.name = "paper";
            this.loses_to = new string[] { "lizard", "scissors" };
            this.wins_against = new string[] { "rock", "spock" };
        }
    }
}
