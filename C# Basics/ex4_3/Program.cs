using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a time value in the 24-hour format (e.g., 19:00): ");
        string userInput = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Invalid Time. No input provided.");
            return;
        }

        if (IsValidTime(userInput))
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }

    static bool IsValidTime(string time)
    {
        if (DateTime.TryParseExact(time, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
        {
 
            return true;
        }

        return false;
    }
}
