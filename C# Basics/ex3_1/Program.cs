using System;
using System.Collections.Generic;
					
internal class Program
{
	public static void Main(string[] args)
	{
        var names = new List <string> ();
		Console.WriteLine("Enter a names of people who like your fb post: ");
        while(true)
        {
            string usr = Console.ReadLine();
            if (!string.IsNullOrEmpty(usr))
            {
                names.Add(usr);
                continue;
            }
            else
            {
                break;
            }
        }
        if (names.Count > 2)
        {
        Console.WriteLine("{0}, {1} and {2} othres liked your post", names[0], names[1], names.Count - 2);
        }
        else if (names.Count == 2)
        {
        Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
        }
        else if (names.Count == 1)
        {
        Console.WriteLine("{0} liked your post", names[0]);
        }
        else 
        {
            Environment.Exit(-1);
        }
        //foreach (var str in names )
            //Console.WriteLine(str);

	
}
}