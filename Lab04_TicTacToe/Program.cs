using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		static void PlayGame()
		{
            // TODO: Instantiate your players
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
            match.Play();
			// Output the winner
		}
	}
}
