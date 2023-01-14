using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        int count2 = 0;
        while (true)
        {
            Console.WriteLine("Enter a number to continue or 'ok' to end program");
            var input = Console.ReadLine();
            bool result = int.TryParse(input, out count);

            if (result != true)
            {
                switch (input)
                {
                    case "ok":
                        Console.WriteLine("Symmarisee {0}", count2);
                        break;

                    default:
                        continue;

                }
                break;
            }
            else
            {
                count2 = count2 + count;
                continue;
            }
        }
    }
}