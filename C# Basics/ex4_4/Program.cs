using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {

        Console.Write("Enter a few words separated by a space: ");
        string userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string pascalCaseVariable = ToPascalCase(userInput);
        Console.WriteLine($"PascalCase variable name: {pascalCaseVariable}");
    }

    static string ToPascalCase(string input)
    {
        string[] words = input.Split(' ');

        System.Text.StringBuilder result = new System.Text.StringBuilder();

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                result.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower());
            }
        }

        return result.ToString();
    }
}
