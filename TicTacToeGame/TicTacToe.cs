using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        char player, computer;
        public void Board()
        {
            Console.WriteLine("Enter Your Letter 'X' or 'Y' ");
            char letter = char.Parse(Console.ReadLine());
            if (letter=='x' || letter=='X')
            {
                player='x';
                computer='y';
            }
            else
            {
                player='y';
                computer='x';
            }

            Console.WriteLine("PLAYER="+player);
            Console.WriteLine("COMPUTER="+computer);

        }
    }
}
