using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MythicalNumbers
{
    class MythicalNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double calc = 0;

            double a = number / 100;
            double b = number / 10 % 10;
            double c = number % 10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            if (c == 0)
            {
                calc = a * b;
            }
            if (c > 0 && c <= 5)
            {
                calc = (a * b) / c;
            }
            if (c > 5)
            {
                calc = (a + b) * c;
            }

            Console.WriteLine("{0:F2}", calc);
        }
    }
}
