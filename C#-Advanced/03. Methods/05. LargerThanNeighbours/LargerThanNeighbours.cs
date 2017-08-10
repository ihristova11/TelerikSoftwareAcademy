using System;

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');

            Larger(n, numbers);
        }

        static void Larger(int n, string[] numbers)
        {
            int counter = 0;

            

            for (int i = 1; i < n - 1; i++)
            {
                if ((int.Parse(numbers[i - 1]) < int.Parse(numbers[i])) && (int.Parse(numbers[i]) > int.Parse(numbers[i + 1])))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
