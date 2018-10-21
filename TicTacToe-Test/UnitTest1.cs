using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace TicTacToe_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CheckWinningGameReturnsTrueTest()
        {
            Player p1 = new Player()
            {
                Marker = "X",
            };

            Player p2 = new Player()
            {
                Marker = "O",
            };
            
            Game game = new Game(p1, p2);
            game.Board.GameBoard = new string[,]
                {
                    {"X", "2", "O"},
                    {"X", "O", "6"},
                    {"X", "8", "9"},
                };

            Assert.True(game.CheckForWinner(game.Board) == true);
        }

        [Fact]
        public void HorizontalWinningGameReturnsTrueTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Board board = new Board();
            board.GameBoard = new string[,] {
                { "X", "X", "X"},
                { "O", "5", "6"},
                { "7", "O", "9"},
            };

            game.Board = board;

            Assert.True(game.CheckForWinner(game.Board) == true);
        }

        [Fact]
        public void SwitchPlayerCorrectlyReturnsTrueTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            p1.IsTurn = true;
            game.SwitchPlayer();

            Assert.True(p2.IsTurn == true);
        }
    }
}
