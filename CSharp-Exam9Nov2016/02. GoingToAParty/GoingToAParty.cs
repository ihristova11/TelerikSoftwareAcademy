using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GoingToAParty
{
    class GoingToAParty
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ind = 0;

            try
            {
                for (; ind < input.Length && ind >= 0;)
                {
                    if (input[ind].ToString() == "^")
                    {
                        Console.WriteLine("Djor and Djano are at the party at {0}!", ind);
                        break;
                    }

                    if (input[ind] >= 'a' && input[ind] <= 'z')
                    {
                        ind += input[ind] - 96;
                    }

                    if (input[ind] >= 'A' && input[ind] <= 'Z')
                    {
                        ind -= input[ind] - 64;
                    }

                    if (ind > input.Length || ind < 0)
                    {
                        Console.WriteLine("Djor and Djano are lost at {0}!", ind);
                        break;
                    }
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Djor and Djano are lost at {0}!", ind);
            }
        }
    }
}
