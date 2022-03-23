using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. provide instructions
            // 1.1 A greeting
            Console.WriteLine("Welcome to Tic Tac Toe Game!");

            // 1.2 Display player sign, player 1 is X and player 2 is O
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine();

            // 1.3 who's turn is it?
            // 1.4 Instruct the user to enter a number between 1 and 9
            Console.WriteLine("Player {X} to move, select through from the game board");
            Console.WriteLine();

            // 2. Draw the game board
            // 2.1 Game will have 3 rows and 3 columns and will be numbered from 1 to 9

            Console.WriteLine(" 1 | 2 | 3");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9");
            Console.WriteLine("---+---+---");

            string userInput = Console.ReadLine();



        }
    }
}
