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
            int s;
            int e;
            string input = "";
            string output = "";
            int counter = 0;
            string input2 = "";


            s = int.Parse(Console.ReadLine());
            while (input2 != "end")
            {
                counter++;
                e = int.Parse(Console.ReadLine());
                counter++;
                input = Console.ReadLine();
                counter++;

                if(e > input.Length)
                {
                    e = input.Length;
                }
                
                if (counter % 2 == 1)
                {
                    if(e < 0)
                    {
                        e = input.Length + e;
                    }

                    if (s < 0)
                    {
                        s = input.Length + s;
                    }
                    
                    for (int i = s; i <= e; i += 3)
                    {
                        output += input[i];
                    }
                }
                else
                {
                    if (e < 0)
                    {
                        e = input.Length  + e;
                    }

                    if (s < 0)
                    {
                        s = input.Length +  s;
                    }

                    for (int i = s; i <= e; i += 4)
                    {
                        output += input[i];
                    }
                }


                input2 = Console.ReadLine();
                if (input2 == "end")
                {
                    break;
                }
                else
                {
                    s = int.Parse(input2);
                }
                
            }
            Console.WriteLine(output);
        }
    }
}
