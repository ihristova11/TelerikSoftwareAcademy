using System;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    public static void Main()
    {
        string number = Console.ReadLine();
        int transform = 0;
        bool transformed = true;
        while(number.Length > 1)
        {
            BigInteger product = 1;
            int sum = 0;
            int position = 0;
            foreach(var symbol in number)
            {
                if (position % 2 == 0)
                {
                    int digit = symbol - '0';
                    sum += digit;
                }
                product *= sum;
                position++;
            }

            product /= sum;
            transform++;
            number = product.ToString();
            if(transform == 10)
            {
                transformed = false;
                //Console.WriteLine(number);
                break;
            }
        }

        if(transformed)
        {
            Console.WriteLine(transform);
        }
        Console.WriteLine(number);
    }
}