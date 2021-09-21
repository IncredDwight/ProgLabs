using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double fullNumber;
            double integerPart;
            double fractionalPart;
            fullNumber = Double.Parse(Console.ReadLine());
            integerPart = (int)fullNumber;
            fractionalPart = (fullNumber * 1000) % 1000;
            Console.WriteLine((double)integerPart / 1000 + fractionalPart);
            Console.ReadLine();

        }
    }
}