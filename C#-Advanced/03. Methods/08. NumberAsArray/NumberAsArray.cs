using System;
using System.Linq;

namespace _08.NumberAsArray
{
    class NumberAsArray
    {

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size0 = input[0];
            int size1 = input[1];
            int one = 0;
            int[] result = new int[Math.Max(size0, size1) + 1];
            int[] num0 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < Math.Min(size0, size1); i++)
            {
                result[i] = (num0[i] + num1[i] + one) % 10;
                one = (num0[i] + num1[i] + one) / 10;
            }

            if (size0 > size1)
            {
                for (int i = size1; i < size0; i++)
                {
                    result[i] = (num0[i] + one) % 10;
                    one = (num0[i] + one) / 10;
                }
            }
            else if (size1 > size0)
            {
                for (int i = size0; i < size1; i++)
                {
                    result[i] = (num1[i] + one) % 10;
                    one = (num1[i] + one) / 10;
                }
            }

            result[Math.Max(size0, size1)] = one;
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 == length)
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                }

                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}