using System;
using System.Linq;
using System.Numerics;
namespace _10.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fact(n);
        }

        static void Fact(int number)
        {
            BigInteger fact = 1;
            for (int i = 1; i < number + 1; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
