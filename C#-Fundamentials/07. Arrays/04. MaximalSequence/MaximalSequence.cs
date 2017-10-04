using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxLen = 0, currLen = 1, prev;
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                prev = x;
                x = int.Parse(Console.ReadLine());
                //prev = x;
                if(prev == x)
                {
                    currLen++;
                    maxLen = (maxLen < currLen) ? currLen : maxLen;
                }
                else
                {
                    currLen = 1;
                }
            }
            Console.WriteLine(maxLen);
        }
    }
}
