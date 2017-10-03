using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MergingNumbers
{
    class MergingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            string summing = "";
            string merging = "";
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                merging += (numbers[i - 1] % 10).ToString();
                merging += (numbers[i] / 10).ToString() + " ";
                summing += (numbers[i - 1] + numbers[i]).ToString() + " ";
            }
            Console.WriteLine(merging);
            Console.WriteLine(summing);
        }
    }
}
