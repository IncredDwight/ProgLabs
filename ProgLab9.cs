using System;


namespace ProgLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int wordLength;
            string[] wordsArray;

            Console.WriteLine("Enter line: ");
            line = Console.ReadLine();

            Console.WriteLine("Enter word's length: ");
            wordLength = Convert.ToInt32(Console.ReadLine());

            wordsArray = line.Split(" ");

            for (int i = 0; i < wordsArray.Length; i++)
                if (wordsArray[i].Length == wordLength)
                    Console.WriteLine(wordsArray[i]);
        }
    }
}
