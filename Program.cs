using System;

namespace ProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.Write("Enter x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            y = Double.Parse(Console.ReadLine());
            if (Math.Abs(y) >= Math.Pow(x, 2) && Math.Abs(x) >= Math.Pow(y, 2))
                Console.WriteLine("Point is inside plane");
            else
                Console.WriteLine("Point is outside plane");
        }
    }
}
