using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HiddenMessage
{
    class HiddenMessage
    {
        static void Main(string[] args)
        {
            string hiddenMessage = "";
            string indStr = Console.ReadLine();

            int i = 0;
            int s = 0;
            string message = "";


            while (indStr != "end")
            {
                i = int.Parse(indStr);
                s = int.Parse(Console.ReadLine());
                message = Console.ReadLine();
                indStr = Console.ReadLine();


                for (int j = i; i < message.Length; i += s)
                {
                    hiddenMessage += message[i];
                }

            }


            //Console.WriteLine(i);
            //Console.WriteLine(s);
            //Console.WriteLine(message);
            Console.WriteLine(hiddenMessage);

        }
    }
}
