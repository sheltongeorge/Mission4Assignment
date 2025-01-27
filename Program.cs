// See https://aka.ms/new-console-template for more information

using Mission4Assignment;



TikTak board = new TikTak();

string[] input = { "1", "2", "3", "4", "X", "O", "7", "8", "9" };

board.GameBoard(input);

TikTak.CheckWinner(input, out string winner);

Console.WriteLine($"Player {winner} wins!");


