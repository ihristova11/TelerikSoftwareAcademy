using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MagicalNumbers
{
    class MagicalNumbers
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double a = num / 100;
            double b = (num / 10) % 10;
            double c = num % 10;

            if (b % 2 == 0)
            {
                Console.WriteLine(((a + b) * c).ToString("F2"));
            }
            else
            {
                Console.WriteLine((((a * b) / c)).ToString("F2"));
            }
        }
    }
}

