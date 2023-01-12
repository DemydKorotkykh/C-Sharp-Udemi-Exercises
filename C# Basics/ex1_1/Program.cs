using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int input = 0;
        
            Console.WriteLine("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
        if (input >= 1 && input <= 10)
        {
            Console.WriteLine("Vallid ");

        }
        else
        {
            Console.WriteLine("Invalid");
        }   

           
    }
            
}

