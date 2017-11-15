namespace _03.DecimalToHexadecimal
{
    using System;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = dec.ToString("X");
            Console.WriteLine(hex);
        }
    }
}
