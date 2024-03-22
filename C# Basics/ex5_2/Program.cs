using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string content = File.ReadAllText("/Users/demydkorotkykh/Programming/C# Udemy courses /C-Sharp-Udemi-Exercises/C# Basics/ex5_2/text.txt");

            string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

            Console.WriteLine(longestWord);
    }

    
}