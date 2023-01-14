using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        for(int i = 1; i <= 100; i++)
        {
            if ((i % 3) == 0)
            {
                count++;
            }

        }
        Console.WriteLine("In range from 1 to 100 is {0} numbers divadable by 3", count);
    }        
}
