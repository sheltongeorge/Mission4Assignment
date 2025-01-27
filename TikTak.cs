using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Reflection;

namespace Mission4Assignment
{
    internal class TikTak
    {
        //2) The supporting class (with whichever name you choose) will:
        //• Receive the “board” array from the driver class
        //• Contain a method that prints the board based on the information passed to it
        //• Contain a method that receives the game board array as input and returns if there is a
        //winner and who it was


        public void GameBoard(char[] board)
        {
            Console.WriteLine(board[0] + " " + board[1] + " " + board[2]);
            Console.WriteLine(board[3] + " " + board[4] + " " + board[5]);
            Console.WriteLine(board[6] + " " + board[7] + " " + board[8]);
        }

        public static bool CheckWinner(char[] board, out char winner)
        {
            // Horizontal check
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                {
                    winner = board[i];
                    return true;
                }
            }

            // Vertical check
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    winner = board[i];
                    return true;
                }
            }

            // Diagnols check
            if (board[0] == board[4] && board[4] == board[8])
            {
                winner = board[0];
                return true;
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                winner = board[2];
                return true;
            }

            winner = "_";
            return false;
        }
    }
}
