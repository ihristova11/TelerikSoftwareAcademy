using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SecretMessage
{
    class SecretMessage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max_x = 0;
            int max_sum = 0, sum = 0, prev = (int)(1e9), curr_len = 0, max_len = 0, curr_sum = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                max_x = (max_x < x) ? x : max_x;

                if(prev >= x)
                {
                    prev = x;
                    if (curr_len > 1 && curr_sum > 0)
                    {
                        if (max_len < curr_len)
                        {
                            max_len = curr_len;
                            max_sum = curr_sum;
                        }
                        else if (max_len == curr_len)
                        {
                            max_sum = (max_sum < curr_sum) ? curr_sum : max_sum;
                        }

                        curr_sum = x;
                        curr_len = 1;
                    }
                    else
                    {
                        curr_len++;
                        curr_sum += x;
                    }
                }

                
            }

            if (curr_len > 1 && curr_sum > 0)
            {
                if (max_len < curr_len)
                {
                    max_len = curr_len;
                    max_sum = curr_sum;
                }
                else if (max_len == curr_len)
                {
                    max_sum = (max_sum < curr_sum) ? curr_sum : max_sum;
                }

                if(max_sum == 0)
                {
                    max_sum = max_x;
                }
            }
            Console.WriteLine(max_sum);
        }
    }
}
