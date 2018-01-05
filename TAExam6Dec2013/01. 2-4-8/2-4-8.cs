using System;

namespace _01._2_4_8
{
    class Program
    {
        static void Main()
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            //int prod = 0;
            ulong r = 0;
            switch (b)
            {
                case 2:
                    r = a % c;
                    break;
                case 4:
                    r = a + c;
                    break;
                case 8:
                    r = a * c;
                    break;
                default:
                    break;
            }

            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 4);
                Console.WriteLine(r);
            }
        }
    }
}
