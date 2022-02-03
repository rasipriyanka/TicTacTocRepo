using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {

       
     static  char player, computer;
     static   char[] arr = new char[10];
        public static void Board()
        {
            
            for (int i = 1; i<=10; i++)
            {

                arr[i]=' ';
            }
        }
        public void BoardPlayer()
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

        public void showBoard()
        {
            
                for (int i = 1; i<10; i++)
                {
                arr[i] = char.Parse(Console.ReadLine());
            }
                Console.WriteLine(arr[1] + "|" + arr[2] + "|" + arr[3]);
                Console.WriteLine("-----");
                Console.WriteLine(arr[4] + "|" + arr[5] + "|" + arr[6]);
                Console.WriteLine("-----");
                Console.WriteLine(arr[7] + "|" + arr[8] + "|" + arr[9]);
            }


        }
    }

