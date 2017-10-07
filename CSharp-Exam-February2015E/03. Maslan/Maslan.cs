using System;
using System.Numerics;

namespace _03.Maslan
{
    class Maslan
    {
        static void Main()
        {
            string number = Console.ReadLine(); // step 1
            int transformations = 0;
            BigInteger product = 1;
            bool transformed = true;
            while (number.Length > 1)
            {
                product = 1;
                //number = number.Substring(0, number.Length - 1); // step 2                                
                int position = 0;
                int sum = 0;
                foreach (var symbol in number)
                {                  
                    
                    if (position % 2 == 1)
                    {
                        sum += symbol - '0';
                    }
                    product *= sum != 0 ? sum : 1;
                    position++;
                }
                product /= sum;
                transformations++;
                number = product.ToString();

                if(transformations == 10)
                {
                    transformed = false;
                    break;
                }
            }

            if(transformed)
            {
                Console.WriteLine(transformations);
            }

            Console.WriteLine(number);
        }
    }
}
