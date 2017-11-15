namespace _01.DecimalToBinary
{
    using System;
    using System.Numerics;
    using System.Text;

    class DecimalToBinary
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(ToNBase(n, 2));                  
        }

        public static string ToNBase(BigInteger a, int n)
        {
            StringBuilder sb = new StringBuilder();
            while (a > 0)
            {
                sb.Insert(0, a % n);
                a /= n;
            }
            return sb.ToString();
        }
    }
}
