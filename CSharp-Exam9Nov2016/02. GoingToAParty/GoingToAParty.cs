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
            int step = 0;
            int ind = 0;


            for (int i = 0; i < input.Length && i >= 0; i += step)
            {
                if (input[i] <= 'z' && input[i] >= 'a')
                {
                    step += input[i] - 96;
                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    step -= input[i] - 64;
                }
                else if (input[i].ToString() == "^")
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", i + 1);
                    break;
                }

                if (i + step < 0 || i + step > input.Length)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", i + step);
                    break;
                }
            }




        }
    }
}
