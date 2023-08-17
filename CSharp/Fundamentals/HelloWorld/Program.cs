// See https://aka.ms/new-console-template for more information
// Starting .NET 6, top level statements are used.

Console.WriteLine("Hello, World!"); // Hello World!

Console.Write("This is a new line."); // Output the string to console.

// Write do not append line feed at end.
Console.Write("This will output on the same line as the previous line."); 
Console.Write("\n"); // Manually adding new line.

Console.WriteLine("This is the third line."); // Output to console and append new line at end.
Console.WriteLine("This is the fourth line."); // Output on new line.

Console.ReadLine();

// Note
// Usual / old format is like: 
// Namespace -> Class -> Member -> Method -> Statements

/*
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // To use command arguments
            // Console.WriteLine("Command: " + args[0])

            // To allow for user input.
            // Can also be used to prevent the console
            // from exiting.
            // Console.ReadLine()

            // String interpolation
            // string name = "James"
            // Console.WriteLine($"Hello {name}!")
        }
    }
}
*/