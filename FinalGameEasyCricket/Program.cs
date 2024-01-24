using System;

namespace EasyCricketGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Easy Cricket!");

            // Create an instance of the Game class
            Game game = new Game();

            // Play innings for the player and computer
            int playerScore = game.PlayInnings("Player");
            int computerScore = game.PlayInnings("Computer");

            // Display final scores and determine the winner
            Console.WriteLine("Player's Score: " + playerScore);
            Console.WriteLine("Computer's Score: " + computerScore);

            if (playerScore > computerScore)
            {
                Console.WriteLine("Congratulations! You win!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("Computer wins. Better luck next time!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
