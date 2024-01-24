using System;

namespace EasyCricketGame
{
    class Game
    {
        // Function to play an innings
        public int PlayInnings(string playerName)
        {
            int totalScore = 0;
            int wickets = 10;

            // Display player's current status
            Console.WriteLine(playerName + "'s Batting Innings:");
            Console.WriteLine("You have " + wickets + " wickets.");
            Console.WriteLine("You have 5 Overs! Score as much as possible!!.");

            // Loop for each inning (maximum 6 innings)
            for (int innings = 1; innings <= 30; innings++)
            {
                // Get the player's valid choice
                int playerChoice = GetValidChoice(playerName);

                // Generate a random computer choice
                Random random = new Random();
                int computerChoice = random.Next(0, 7);

                // Display player and computer choices
                Console.WriteLine(playerName + ": " + playerChoice);
                Console.WriteLine("Computer: " + computerChoice);

                // Check if player is out or scored runs
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Out!");
                    wickets--;
                }
                else
                {
                    Console.WriteLine("Runs scored: " + playerChoice);
                    totalScore += playerChoice;
                }

                // Display current score and wickets
                Console.WriteLine(playerName + "'s Score: " + totalScore);
                Console.WriteLine("Wickets left: " + wickets);

                // Check if player is out of wickets
                if (wickets == 0)
                {
                    Console.WriteLine(playerName + "'s Innings Over. Total Score: " + totalScore);
                    break;
                }
            }

            return totalScore;
        }

        // Function to get a valid choice from the player
        private int GetValidChoice(string playerName)
        {
            Console.Write(playerName + ", enter your choice (0-6): ");
            int playerChoice = int.Parse(Console.ReadLine());

            // Validate player's choice
            if (playerChoice < 0 || playerChoice > 6)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                return GetValidChoice(playerName); // Recursively call until valid choice is entered
            }

            return playerChoice;
        }
    }
}
