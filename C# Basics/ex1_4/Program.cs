using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int limit = 0;
        int car = 0;
        int count = 0;
            Console.WriteLine("Enter the speed limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car: ");
            car = Convert.ToInt32(Console.ReadLine());
            count = car - limit;
        if (limit > car)
        {
            Console.WriteLine("Ok");

        }
        else
        {
            if( count >= 60)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                count = count / 5;
                Console.WriteLine("{0} demerit points", count);
            }
        }   

           
    }
            
}


