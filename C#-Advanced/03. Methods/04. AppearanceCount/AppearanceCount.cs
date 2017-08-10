using System;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int number = int.Parse(Console.ReadLine());

            Counter(number, numbers, n);

        }


        public static void Counter(int number, string[] numbers, int n)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(numbers[i]) == number)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
