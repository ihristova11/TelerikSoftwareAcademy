namespace _06.BinaryToHexadecimal
{
    using System;

    class BinaryToHexadecimal
    {
        static void Main()
        {
            string bin = Console.ReadLine();
            long dec = Convert.ToInt64(bin, 2);
            Console.WriteLine(dec.ToString("X"));
        }
    }
}
