internal class Program
{
    private static void Main(string[] args)
    {
        string choice = "";
        bool winner = false;
        List<char> numbers = new List<char> {'1','2','3','4','5','6','7','8','9'};


        Console.WriteLine("Welcome to the Tic Tac Toe game! ");

        do // grid[5]
        {
            // Print the game board

            // Determine Current Player
            int currentPLayer = 1;

            Console.WriteLine($"It is Player {currentPLayer}'s turn. Where would you like to place your marker?");
            // Validate the Input
           
            // Update GameBoard

            // Check for a winner

            // Check for a draw

            // Alternate Players

            // Code block to be executed

            
        } while (!winner);
    }

    
}