using System;
using System.IO;

class Program
{
    static void Main()
    {
        string content = File.ReadAllText("/your/path/ex5_1/text.txt");

            string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length);
    }

    
}
