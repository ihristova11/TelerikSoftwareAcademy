namespace _02.EvenDifferences
{
    using System;
    using System.Linq;
    using System.Numerics;

    class EvenDifferences
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            long evenSum = 0;
            int jumps = 1;
            long difference = 0;

            for (int i = 1; i < numbers.Length; i+=jumps)
            {
                if(numbers[i] > numbers[i-1])
                {
                    difference = numbers[i] - numbers[i - 1];
                }
                else
                {
                    difference = numbers[i - 1] - numbers[i];
                }

                if (difference % 2 == 0)
                {
                    evenSum += difference;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
