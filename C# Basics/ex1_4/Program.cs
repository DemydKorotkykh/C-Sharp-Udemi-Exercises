using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int limit = 0;
        int car = 0;
            Console.WriteLine("Enter the speed limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car: ");
            car = Convert.ToInt32(Console.ReadLine());
        if (limit > car)
        {
            Console.WriteLine("Ok");

        }
        else
        {
            if( (car - limit) >= 60)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine( (car - limit)/5 + " demerit points");
            }
        }   

           
    }
            
}


