using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int a = 0;
        int b = 0;
        
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine( a );

        }
        else
        {
            Console.WriteLine( b );
        }   

           
    }
            
}


