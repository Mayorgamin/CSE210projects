
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        
        int userInput = int.Parse(Console.ReadLine());
        string letter = "";


        if (userInput >= 90)
        {
            letter = "A";
        }
        else if (userInput >= 80 && userInput <90)
        {
            letter = "B";
        }
        else if (userInput >= 70 && userInput <80)
        {
            letter = "C";
        }
        else if (userInput >= 60 && userInput <70)
        {
            letter = "D";
        }
        else
        {

            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");


        if (userInput >= 70)
        {
            Console.WriteLine("Congratulations! You've passed the course.");
        }
        if (userInput < 70)
        {
            Console.WriteLine("Unfortunately you haven't passed this time. Try again next semestre.");
        }
    }
}