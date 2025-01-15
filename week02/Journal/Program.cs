using System;

class Program
{
    static string name;
    static int number;
    static int square;

    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts the user for their name and stores it in the global variable 'name'
    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }

    // Prompts the user for their favorite number and stores it in the global variable 'number'
    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());
    }

    // Calculates the square of the global variable 'number' and stores it in the global variable 'square'
    static void SquareNumber()
    {
        square = number * number;
    }

    // Displays the result using the global variables 'name' and 'square'
    static void DisplayResult()
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}.");
    }
}

