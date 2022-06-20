using RPSLS.Gestures;

namespace RPSLS.Players
{
    internal class AI : Player
    {
        public AI() : base("Al the AI")
        {

        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int randomIndex = random.Next(gestures.Length);
            gestureChoice = gestures[randomIndex];
            Console.WriteLine($"{name} picked {gestureChoice.name}");
        }
    }
}
