using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an English word: ");
        string userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("No word provided.");
            return;
        }

        int vowelCount = CountVowels(userInput);
        Console.WriteLine($"Number of vowels in the word: {vowelCount}");
    }

    static int CountVowels(string word)
    {
        int count = 0;

        foreach (char letter in word.ToLower())
        {
            if ("aeiou".Contains(letter))
            {
                count++;
            }
        }

        return count;
    }
}
