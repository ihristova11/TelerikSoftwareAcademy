using System;
using System.Numerics;

class ConsoleApp1
{
    public static void Main()
    {
        BigInteger product = 1;
        string input = Console.ReadLine();
        int num;
        int counter = 1;
        int position = 0;
        int digitsProduct = 1;
        while (input != "END")
        {
            if (counter <= 10)
            {
                if (position % 2 == 1)
                {
                    num = int.Parse(input);
                    if (num == 0) digitsProduct = 1;
                    int digit;
                    while (num != 0)
                    {
                        digit = num % 10;
                        if (digit == 0) digit = 1;
                        digitsProduct *= digit;
                        num /= 10;
                    }
                    product *= digitsProduct;
                    digitsProduct = 1;
                }
            }
            else
            {
                Console.WriteLine(product);
                product = 1;
                counter -= 10;
            }
            input = Console.ReadLine();
            counter++;
            position++;
        }

        Console.WriteLine(product);
    }
}
