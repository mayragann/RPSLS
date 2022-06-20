using RPSLS.Players;

namespace RPSLS
{
    internal class Game 
    {

        private Human player1;
        private Player player2;

        public Game()
        {
            this.player1 = new Human("Player 1");
            this.player2 = new Human("Player 2");
        }

        public void RunGame()
        {
            DisplayWelcome();
            ChooseGameMode();
            Battle();
            DisplayWinner();
        }

        private void DisplayWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine($"{player1.name} wins!\n");
            }
            if (player2.score == 2)
            {
                Console.WriteLine($"{player2.name} wins!\n");
            }
        }

        private static void DisplayWelcome()
        {
            Console.WriteLine("Hello! Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        }

        private void ChooseGameMode()
        {
            while (true)
            {
                Console.WriteLine("Please select a game mode:\n\n\t(1)\tSingle-Player Game\n\t(2)\tMultiplayer Game\n");
                string gameModeChoice = Console.ReadLine();
                if (gameModeChoice == "1")
                {
                    player2 = new AI();
                    player1.SetName();
                    break;
                } else if (gameModeChoice == "2")
                {
                    player2 = new Human("Player 2");
                    player1.SetName();
                    player2.SetName();
                    break;
                } else
                {
                    Console.WriteLine("Please choose one of the above options.");
                }
            }
        }

        private void Battle()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                Player winner = ChooseWinner();
                PrintWinner(winner);
            }
        }

        private Player ChooseWinner()
        {
            if (player1.gestureChoice.loses_to.Contains(player2.gestureChoice.name))
            {
                return player2;
            } else if (player1.gestureChoice.wins_against.Contains(player2.gestureChoice.name))
            {
                return player1;
            } else
            {
                return null;
            }
        }

        private void PrintWinner(Player winner)
        {
            if (winner == null)
            {
                Console.WriteLine("\nIt's a tie!");
            } else
            {
                Console.WriteLine($"\n{winner.name} won the round!");
                winner.score += 1;
                Console.WriteLine($"\n{winner.name} has a score of {winner.score}.");
            }
        }
    }
}
