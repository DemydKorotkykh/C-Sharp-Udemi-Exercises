using System;

internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Your name: ");
        string usrinp = Console.ReadLine();
        char[] lettres = usrinp.ToCharArray();
        Array.Reverse(lettres);
        string reverse = new string (lettres);
        Console.WriteLine(reverse);
    }
}