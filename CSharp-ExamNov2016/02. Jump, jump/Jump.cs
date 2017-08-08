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

            int position = 0;

            if (int.Parse(instructions[position].ToString()) % 2 == 0)
            {
                position += int.Parse(instructions[position].ToString()); //go to new position +++
            }
            else
            {
                position -= int.Parse(instructions[position].ToString()); // go back to new position

            }
            try
            {
                if (instructions[position] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", position);
                }
                if (position == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", position);
                }
                if (position < 0 && position >= instructions.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", position);
                }

                //Console.WriteLine(position);

                while ((position > 0 && position < instructions.Length) || position != 0 || instructions[position] != '^')
                {
                    if (instructions[position] % 2 == 0)
                    {
                        position += int.Parse(instructions[position].ToString());
                    }
                    else
                    {
                        position -= int.Parse(instructions[position].ToString());
                    }

                    if (position < 0 && position >= instructions.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", position);
                        break;
                    }
                    if (position == 0)
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", position);
                        break;
                    }
                    if (instructions[position] == '^')
                    {
                        Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", position);
                        break;
                    }

                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", position);
            }
        }

    }
}
