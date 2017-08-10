using System;
using System.Linq;

namespace _09.SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SortArray(numbers, n);
        }

        static void SortArray(int[] arr, int length)
        {
            //int[] sorted = new int[length];
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
