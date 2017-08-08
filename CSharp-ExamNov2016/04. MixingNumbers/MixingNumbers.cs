using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MixingNumbers
{
    class MixingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] substract = new int[n - 1];
            int[] mix = new int[n - 1];
            int[] numbers = new int[n];

            for (int j = 0; j < n; j++)
            {
                numbers[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                substract[i] = Math.Abs(numbers[i] - numbers[i + 1]);
                mix[i] = (numbers[i] % 10) * (numbers[i + 1] / 10);
                
            }
            Console.WriteLine(string.Join(" ", mix));
            Console.WriteLine(string.Join(" ", substract));
        }
    }
}
