using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int newNumber = -1;
        
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

           
            if (newNumber != 0)
            {
                numbers.Add(newNumber); 
      
            }         
            
        }

        int sum = 0;
        int largest = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }


        } 
            double average = (double)sum / numbers.Count;
            
    
            Console.WriteLine($"The sum is: {sum} ");
            Console.WriteLine($"The average is: {average} ");
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine();
    }
}