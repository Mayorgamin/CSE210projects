using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessCount = 0;
        int guess; 

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

    
        while (guess != magicNumber)
        {
            
            if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
                               
            }
            else if (guess > magicNumber)
            {
            Console.WriteLine("Lower");
            
            }
        guessCount++;

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        }
        
        guessCount++;
        
        Console.WriteLine("You guessed it!");
        Console.Write($"It took you {guessCount} guesses");
        Console.WriteLine();
        // Console.WriteLine();

        Console.Write("Do you want to play again? (yes/no) ");
        playAgain = Console.ReadLine().ToLower();

    } while (playAgain == "yes");
    Console.WriteLine("Thanks for playing! Goodbye!");
    } 
   
}