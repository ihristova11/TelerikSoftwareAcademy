using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int prev, curr_len = 1, max_len = 0;

            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                prev = x;
                x = int.Parse(Console.ReadLine());
                if (prev < x)
                {
                    curr_len++;
                    max_len = (max_len < curr_len) ? curr_len : max_len;
                }
                else
                {
                    curr_len = 1;
                }
            }
            Console.WriteLine(max_len);
        }
    }
}
