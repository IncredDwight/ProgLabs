using System;

namespace ProgLab9
{
    class Program
    {
        static string line;
        static int wordLength;

        static void Main(string[] args)
        {
            Init();
            DisplayWords(GetWords(line), wordLength);
        }

        static void Init()
        {
            Console.WriteLine("Enter line: ");
            line = Console.ReadLine();
            Console.WriteLine("Enter word length: ");
            wordLength = Convert.ToInt32(Console.ReadLine());
        }

        static string[] GetWords(string line)
        {
            string[] words = line.Split(" ");
            return words;
        }

        static void DisplayWords(string[] words, int length)
        {
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == length)
                    Console.WriteLine(words[i]);
            }
        }

    }
}
