/* Number Guessing Game
 * 
 * This is a console-based game where the program randomly 
 * picks a number between 1 and 100. The user then has to 
 * guess what the number is. After each guess, the program 
 * tells the user if they guessed too high or too low. The 
 * user keeps guessing until they get the number right. To 
 * make it more interesting, you can keep track of the 
 * number of guesses.
 * 
 * Random number 1 - 100.
 * User input - number.
 * Check if user number equals program number.
 * Tells user is guess number is too high or too low.
 * Win when user number equals program number.
 * Track number of tries.
 * Add a penalty for typing a non number, string, wrong 
 *     format number e.g +5 tries.
 * 
 */

Random random = new();
int solutionNumber = random.Next(1, 101);
int userNumber = 0;
int tries = 0;

// Console.WriteLine(solutionNumber); // Only for debugging purpose.
while (solutionNumber != userNumber)
{
    Console.Write("Enter your guess: ");
    string? userInput = Console.ReadLine();
    if (userInput != "")
    {
        if (int.TryParse(userInput, out userNumber))
        {
            if (solutionNumber == userNumber)
            {
                Console.WriteLine("You WIN!");
                Console.WriteLine("");
                Console.WriteLine($"Number of tries: {tries}");
            }
            else if (userNumber > solutionNumber)
            {
                Console.WriteLine("Too HIGH!");
                tries++;
            }
            else
            {
                Console.WriteLine("Too LOW!");
                tries++;
            }
        }
        else
        {
            Console.WriteLine("Error! Wrong number format.");
        }
    }
    else
    {
        Console.WriteLine("You must write a number.");
    }
}