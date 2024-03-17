using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables

            // Creating human (you) container for dice roll
            int playerRandomNum;

            // Creating AI container for dice roll 
            int enemyRandomNum;

            // Starting human player points
            int playerPoints = 0;

            // Starting AI points
            int enemyPoints = 0;

            // Random number generator
            Random random = new Random();

            // Game loop
            // Runs 10 times
            for (int i = 0; i < 10; i++) {

                // User input required for round to start
                Console.WriteLine("Press any key to roll the dice.");

                // Waiting for player input
                Console.ReadKey();

                // Calling random to get the human player's dice roll
                playerRandomNum = random.Next(1, 7);

                // Noting human player's dice roll value in console
                Console.WriteLine("You rolled a " + playerRandomNum);

                // Wait for 1/2 second
                System.Threading.Thread.Sleep(500);

                // Buffer
                Console.WriteLine("...");

                // Wait 1 second
                System.Threading.Thread.Sleep(1000);

                // Calling random to get the AI's dice roll
                enemyRandomNum = random.Next(1, 7);

                // Noting human AI's dice roll value in console
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);
                System.Threading.Thread.Sleep(500);

                // Outcome dependant on who rolled the highest number
                // Draw if numbers rolled are the same
                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw. No one wins.");
                }
                
                // Prints current score (factoring in last round outcome) for both human player and AI
                Console.WriteLine("Score is now - Player: " + playerPoints + ", Enemy: " + enemyPoints + ".");

                // Buffer
                Console.WriteLine();

                // Break
                Console.WriteLine("--------------------------------");
                
                // Buffer
                Console.WriteLine();
            }

            // Buffer
            Console.WriteLine();

            // Prints who wins based on score after 10 rounds 
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            } 
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            // Input needed from user to close program
            Console.ReadKey();
        }
    }
}
