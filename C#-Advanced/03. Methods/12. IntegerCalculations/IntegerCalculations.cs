using System;
using System.Linq;
using System.Numerics;
namespace _12.IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("{0:f2}",numbers.Average());
            Console.WriteLine(numbers.Sum());
            //FindMinElement(numbers);
            //FindMaxElement(numbers);
            //FindAverage(numbers);
            //Sum(numbers);
            FindProduct(numbers);
        }

        //static void Sum(int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }

        //    Console.WriteLine(sum);
        //}

        //static void FindMinElement(int[] numbers)
        //{
        //    int min = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = 1; j < numbers.Length; j++)
        //        {
        //            min = Math.Min(numbers[j - 1], numbers[j]);
        //        }
        //    }
        //    Console.WriteLine(min);
        //}

        //static void FindMaxElement(int[] numbers)
        //{
        //    int max = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = 1; j < numbers.Length; j++)
        //        {
        //            max = Math.Max(numbers[j - 1], numbers[j]);
        //        }
        //    }
        //    Console.WriteLine(max);
        //}

        static void FindProduct(int[] numbers)
        {
            BigInteger product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine(product);
        }

        //static void FindAverage(int[] numbers)
        //{
        //    double average = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        average += numbers[i];
        //    }

        //    average = average / numbers.Length;

        //    Console.WriteLine("{0:f2}", average);
        //}
    }
}
