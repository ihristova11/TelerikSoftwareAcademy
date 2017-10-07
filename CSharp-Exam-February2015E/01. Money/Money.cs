using System;

namespace _01.Money
{
    class Money
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f3}", (n * s * p / 400));
        }
    }
}
