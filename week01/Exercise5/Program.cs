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



    static void DisplayWelcome()
    {   
        Console.WriteLine("Welcome to the program!");
    }

       
        static void PromptUserName()
    {   
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }

        static void PromptUserNumber()
     {   
         Console.Write("Please enter your favorite number: ");
         number = int.Parse(Console.ReadLine());
    
     }
    
        static void SquareNumber()
    {   

        square = number * number;

    }


        static void DisplayResult()
    {   
        Console.Write($"Brother {name}, the square of your number is {square}");
        Console.WriteLine();

    }
}