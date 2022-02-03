using System;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe obj = new TicTacToe();
            obj.BoardPlayer();

            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.showBoard();
        }
    }
}
