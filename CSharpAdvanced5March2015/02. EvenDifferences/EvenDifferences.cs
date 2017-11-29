namespace _02.EvenDifferences
{
    using System;
    using System.Linq;
    using System.Numerics;

    class EvenDifferences
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long evenSum = 0;
            long difference = 0;
            int i = 1;

            while (i < numbers.Length)
            {
                difference = Math.Abs(numbers[i] - numbers[i - 1]);

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
