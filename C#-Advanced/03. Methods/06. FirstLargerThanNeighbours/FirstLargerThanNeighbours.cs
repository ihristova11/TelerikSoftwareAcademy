using System;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');

            Console.WriteLine(FirstLarger(n, numbers));
            //Console.WriteLine((int.Parse(numbers[i]) > int.Parse(numbers[i - 1])) && (int.Parse(numbers[i]) < int.Parse(numbers[i + 1])));
        }

        static int FirstLarger(int n, string[] numbers)
        {
            int index = -1;
            for (int i = 1; i < n - 1; i++)
            {
                if ((int.Parse(numbers[i - 1]) < int.Parse(numbers[i])) && (int.Parse(numbers[i]) > int.Parse(numbers[i + 1])))
                {
                    index = i;
                    break;
                }
                //Console.WriteLine(((int.Parse(numbers[i - 1]) < int.Parse(numbers[i])) && (int.Parse(numbers[i]) > int.Parse(numbers[i + 1]))));
            }

            return index;
        }
    }
}
