using System;

namespace _10.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            char[] line = Console.ReadLine().ToCharArray();
            //Console.WriteLine(Fact(number));
            //Console.WriteLine(line[1]);
            string num = "";
            for (int i = 0; i < line.Length; i++)
            {
                num += line[i];
            }

            Console.WriteLine(Fact(int.Parse(num)));
        }

        static int Fact(int number)
        {
            int fact = 1;
            for (int i = 1; i < number + 1; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
