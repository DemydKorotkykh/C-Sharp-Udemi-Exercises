using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        var count = new  List <int>();
        var junk = 0;
            Console.WriteLine("Enter a number to continue or 'Quit' to end program");
        while (true)
        {
                var input = Console.ReadLine();
                bool result = int.TryParse(input, out junk);

            if (result != true)
            {
                switch (input)
                {
                    case "Quit":
                    Console.WriteLine();
                    foreach(var n in count)
                    {
                        Console.WriteLine(n);
                    }
                        break;

                    default:
                        continue;

                }
                break;
            }
            else
            {
                count.Add(junk);
                continue;
            }
            
        }
    }
}