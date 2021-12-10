using System;

namespace ProgLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            FillArray(array);

            int maxElement = GetMaxElement(array);
            int minElement = GetMinElement(array);

            Console.WriteLine("Difference: " + (maxElement - minElement));

            Swap(array, minElement, array[array.Length - 1]);
        }

        static void FillArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-100, 101);
            }
        }

        static int GetMaxElement(int[] array)
        {
            int maxElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        static int GetMinElement(int[] array)
        {
            int minElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (minElement > array[i])
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }

        static int GetIndex(int[] array, int element)
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                    index = i;
            return index;
        }

        static void Swap(int[] array, int element1, int element2)
        {
            int firstIndex = GetIndex(array, element1);
            int secondIndex = GetIndex(array, element2);
            array[firstIndex] = element2;
            array[secondIndex] = element1;
        }
    }
}
