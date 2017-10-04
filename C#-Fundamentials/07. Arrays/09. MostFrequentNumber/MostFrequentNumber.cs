using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            int maxTimes = int.MinValue;
            int mostFrequent = 1;
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int j = 1; j < n; j++)
            {
                if(arr[j -1] == arr[j])
                {
                    times++;
                    if(maxTimes < times)
                    {
                        maxTimes = times;
                        mostFrequent = arr[j];
                    }
                }
                else
                {
                    times = 0;
                }
            }
            Console.WriteLine("{0} ({1} times)", mostFrequent, maxTimes + 1);
        }
    }
}
