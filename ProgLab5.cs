using System;

namespace ProgLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 4; i++)
            {
                for(int j = 10; j < 10000; j++)
                {
                    if (Math.Pow((j / 1000) % 10, i) + Math.Pow((j / 100) % 10, i) + Math.Pow((j / 10) % 10, i) + Math.Pow(j % 10, i) == j)
                        Console.WriteLine(j + "\n");
                }
            }
        }
    }
}
