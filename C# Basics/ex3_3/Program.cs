using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var numbers = new int[5];
        while (true)
        {
            Console.WriteLine("Enter 5 digits: ");
            for (int i = 0; i != 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (numbers.Length != numbers.Distinct().Count())
            {
                Console.WriteLine("Try again, do not use same digit twice");
                continue;
            }
            else
            {
                Array.Sort(numbers);
                Console.WriteLine();
                Console.WriteLine("Results after sorting");
                foreach (var n in numbers)
                {
                    Console.WriteLine(n);
                }
                break;
            }
        }
    }
}