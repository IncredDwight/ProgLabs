using System;

namespace ProgLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float sum = 0;

            int n;

            Console.WriteLine("Enter x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            
            
            for(int i = 0; i <= n; i++)
            {
                long factorial = 1;
                for (int j = 1; j <= i; j++)
                    factorial *= j;
                sum += (MathF.Pow(x, i)) / factorial;
            }

            Console.WriteLine("Result: " + sum);
        }
    }
}
