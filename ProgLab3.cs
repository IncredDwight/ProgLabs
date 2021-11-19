using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            const float x = 0.56f;
            double edge;
            edge = Math.Pow(10, -4);

            for (int n = 0; Math.Abs(GetExpression(n)) > edge; n++)
            {
                s += Math.Pow(-1, n) * GetExpression(n);
                Console.WriteLine(n);
            }
            
            Console.WriteLine(s);

            double GetExpression(int n)
            {
                return (Math.Pow(x, 2 * n) + 1) / (Math.Pow(2, n) + 1);
            }
        }
    }
}
