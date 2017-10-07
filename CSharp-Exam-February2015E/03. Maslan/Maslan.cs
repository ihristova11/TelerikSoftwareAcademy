using System;

namespace _03.Maslan
{
    class Maslan
    {
        static void Main()
        {
            string number = Console.ReadLine(); // step 1

            while(number.Length > 1)
            {
                number = number.Substring(0, number.Length - 1); // step 2 

                int sum = 0;
                int position = 0;
                foreach (var symbol in number)
                {
                    if(position % 2 == 1)
                    {
                        sum += symbol - '0';
                    }
                    position++;
                }
            }
        }
    }
}
