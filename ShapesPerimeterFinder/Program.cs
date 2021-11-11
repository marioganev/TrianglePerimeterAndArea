using System;

namespace ShapesPerimeterFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Triangle Perimeter & Area Finder");
            Console.WriteLine("         by Mario Ganev");
            Console.WriteLine("");
            int a, b, c, h, p, s;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("h = ");
            h = int.Parse(Console.ReadLine());
            s = h * b / 2;
            p = a + b + c;
            Console.WriteLine("");
            

            Console.WriteLine("Perimeter = " + p);
            Console.WriteLine("Area = " + s);

        }
    }
}
