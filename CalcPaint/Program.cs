using InkCalculator;
using System;

namespace CalcPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            const double HEIGHT = 2.9; 
            Console.WriteLine("How wide is the room?");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("How deep is the room?");
            double depth = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of ​​the walls is:");
            Console.WriteLine(calculator.CalculateWallArea(HEIGHT, width, depth));

          
            Console.WriteLine("The ceiling area is:");
            Console.WriteLine(calculator.CalculateCeilingArea(width, depth));

            Console.WriteLine("The required paint finish is:");
            double ink_litring = calculator.CalculateRequiredLiteracy();
            Console.WriteLine(ink_litring);

            Console.WriteLine("Finished!");
            Console.ReadKey();
        }
    }
}
