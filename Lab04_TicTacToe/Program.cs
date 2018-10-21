using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            PlayGame();
		}

		static void PlayGame()
		{
            // DONE: Instantiate your players
            Console.WriteLine("By what name shall I refer to the first player?");
            string input = Console.ReadLine();
            Player p1 = new Player()
            {
                Name = input,
                Marker = "X"
            };

            Console.WriteLine("By what name shall I refer to the second player?");
            input = Console.ReadLine();
            Player p2 = new Player()
            {
                Name = input,
                Marker = "O"
            };

            // Create the Game
            Game match = new Game(p1, p2);

            // Play the Game
            string final = match.Play().Name;
            // Output the winner
            if (final != null)
            {
                Console.WriteLine($"{final} wins!");
            }
            else
            {
                Console.WriteLine("We're all losers today");
            }
            Console.WriteLine("Would you like to play again? y/n");
            input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                PlayGame();
            }

        }
	}
}
