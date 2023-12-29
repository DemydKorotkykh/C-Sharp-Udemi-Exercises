using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by a hyphen: ");
        string userInput = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Exiting program. No input provided.");
            return;
        }

        if (HasDuplicates(userInput))
        {
            Console.WriteLine("Duplicate");
        }
        else
        {
            Console.WriteLine("No Duplicate");
        }
    }

    static bool HasDuplicates(string numbers)
    {

        int[] numbersArray = numbers.Split('-')
                                      .Select(num => int.Parse(num))
                                      .ToArray();

        return numbersArray.Length != numbersArray.Distinct().Count();
    }
}
 
