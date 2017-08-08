using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Jump__jump
{
    class Jump
    {
        static void Main(string[] args)
        {
            string instructions = Console.ReadLine();
            int boundaries = instructions.Length;

            for (int i = 0; i < boundaries;)
            {

                if (instructions[i] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    break;
                }
                else if (instructions[i] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }
                else if (instructions[i] % 2 == 0)
                {
                    int value = instructions[i] - '0';
                    int next = i + value;
                    if (next > (boundaries - 1) || next < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", next);
                        break;
                    }
                    else
                    {
                        i = next;
                    }
                }
                else if (instructions[i] % 2 != 0)
                {
                    int value = instructions[i] - '0';
                    int next = i - value;
                    if (next > (boundaries - 1) || next < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", next);
                        break;
                    }
                    else
                    {
                        i = next;
                    }

                }
            }
        }
    }
}
