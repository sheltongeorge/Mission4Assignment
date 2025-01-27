using Mission4Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        string choice = "";
        bool winner = false;
        List<char> board = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        Console.WriteLine("Welcome to the Tic Tac Toe game!");

        int currentPlayer = 1;

        do
        {
            // Print the game board
            TikTak.GameBoard(board);

            // Determine Current Player
            Console.WriteLine($"It is Player {currentPlayer}'s turn. Where would you like to place your marker?");

            // Validate the Input
            choice = ValidateInput(board);

            // Update GameBoard
            int choiceNumeric = int.Parse(choice);
            board[choiceNumeric - 1] = (currentPlayer % 2 == 0 ? 'O' : 'X');

            // Check for a winner
            winner = TikTak.CheckWinner(board, out char winningPlayer);

            if (winner)
            {
                TikTak.GameBoard(board);
                Console.WriteLine($"Player {winningPlayer} wins! Congratulations!");
                break;
            }

            // Check for a draw
            if (board.All(cell => cell == 'X' || cell == 'O'))
            {
                TikTak.GameBoard(board);
                Console.WriteLine("It's a draw! No more moves left.");
                break;
            }

            // Alternate Players
            currentPlayer = currentPlayer == 1 ? 2 : 1;

        } while (!winner);
    }

    private static string ValidateInput(List<char> board)
    {
        bool validInput = false;
        string choice = "";

        do
        {
            choice = Console.ReadLine();

            // Check if the input is valid
            if (int.TryParse(choice, out int position) && position >= 1 && position <= 9 && board[position - 1] != 'X' && board[position - 1] != 'O')
            {
                validInput = true; // Input is valid
            }
            else
            {
                Console.WriteLine("Invalid input! Please choose an available number between 1 and 9.");
            }
        } while (!validInput);

        return choice; // Return the valid choice
    }
}
