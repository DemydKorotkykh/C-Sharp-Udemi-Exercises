using System;
					
internal class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a series of numbers, seperated by commas: ");
           
			var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

	}
}