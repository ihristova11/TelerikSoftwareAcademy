using System;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int temp;
            for(int i = 0; i < n;i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if(numbers[j] > numbers[k])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[k];
                        numbers[k] = temp;
                    }
                }
            }

            for (int p = 0; p < n; p++)
            {
                Console.WriteLine(numbers[p]);
            }
        }
    }
}
