using System;

namespace ProgLab6
{
    class Program
    {
        static int a, b, c;
        static int result;

        static void Main(string[] args)
        {
            Init();
            Solution();
            Browse();
        }
        
        static void Init()
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
        }

        static int Gcd(int num1, int num2)
        {
            while(num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            return num1;
        }

        static void Solution()
        {
            result = Gcd(Gcd(a, b), c);
        }

        static void Browse()
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
