using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int width = 0;
        int height = 0;
        
            Console.WriteLine("Enter width of image: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of image: ");
            height = Convert.ToInt32(Console.ReadLine());
        if (width > height)
        {
            Console.WriteLine("Landscape");

        }
        else
        {
            Console.WriteLine("Portrate");
        }   

           
    }
            
}


