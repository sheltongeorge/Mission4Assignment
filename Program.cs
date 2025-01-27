internal class Program
{
    private static void Main(string[] args)
    {
        bool winner = false;
        List<char> numbers = new List<char> {'1','2','3','4','5','6','7','8','9'};


        Console.WriteLine("Welcome to the Tic Tac Toe game! ");

        do // grid[5]
        {
            // Print the game board
            SupportingClass.printboard(numbers);

            // Determine Current Player

            // Validate the Input

            string ValidateInput(List<string> board)
            {
                bool validInput = false;

                do
                {
                    choice = Console.ReadLine();

                    // Check if the input is a valid number in the board
                    if (board.Contains(choice))
                    {
                        validInput = true; // Input is valid if the position is still available
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please choose an available number.");
                    }

                } while (!validInput);

                return choice; // Return the valid choice
            }


            // Update GameBoard

            // Check for a winner

            // Check for a draw

            // Alternate Players

            // Code block to be executed
        } while (!winner);
    }

    
}