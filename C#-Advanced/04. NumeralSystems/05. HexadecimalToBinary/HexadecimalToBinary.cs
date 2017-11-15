namespace _05.HexadecimalToBinary
{
    using System;
    using System.Text;

    class HexadecimalToBinary
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            long dec = Convert.ToInt64(hex, 16);
            Console.WriteLine(ToNBase(dec, 2));
        }

        public static string ToNBase(long a, int n)
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
