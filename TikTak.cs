using System;
using System.Collections.Generic;

namespace Mission4Assignment
{
    internal class TikTak
    {
        // Print the game board
        public static void GameBoard(List<char> board)
        {
            Console.WriteLine();
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine();
        }

        // Check if there is a winner
        public static bool CheckWinner(List<char> board, out char winner)
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

            // Diagonal checks
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

            winner = ' ';
            return false;
        }
    }
}
