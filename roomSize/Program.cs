using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomSize
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;
            string willContinue = "y";

            Console.WriteLine("Welcome to the room size generator!");
            while (willContinue == "y")
            {


                Console.WriteLine("What is the length of the room?");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the room?");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = length * 2 + width * 2;
                double volume = length * width * height;

                Console.WriteLine("Area= " + area);
                Console.WriteLine("Perimeter= " + perimeter);
                Console.WriteLine("Volume= " + volume);
                Console.WriteLine("Do you have more rooms to calculate? y or n");
                willContinue = Console.ReadLine();

            }
                Console.WriteLine("Thank you for using the room calculator.");






        }
        
    }
}
