using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.WriteLine("Enter a number to calculate factorial:");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = input;
            for(int i = input - 1; i > 0; i--)
            {
                count = count * i;
            }

         Console.WriteLine("Symmarisee {0}! = {1}", input, count);
            
            
            
    }
}