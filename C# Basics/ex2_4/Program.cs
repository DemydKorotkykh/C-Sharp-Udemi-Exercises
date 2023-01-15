using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Random rnd = new Random();
        int random = new Random().Next(1, 10);
        Console.WriteLine("Guess number");
        for (int i = 4; i > 0; i--)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == random)
            {
                Console.WriteLine("You won");
                break;
            }
            else
            {
                Console.WriteLine("You lost");
                continue;
            }
        }
    }
}