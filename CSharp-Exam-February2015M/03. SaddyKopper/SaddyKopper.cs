using System;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    public static object BigInteger { get; private set; }

    static void Main()
    {
        string number = Console.ReadLine();
        //number = number.Substring(number.Length - 1, 1);
        BigInteger product = 1;

        int sum = 0, transformations = 0;
        while (number.Length > 1 && transformations < 10)
        {
            product = 1;
            while (number.Length > 0)
            {
                number.Remove(number.Length - 1, 1);
                sum = 0;
                for (int i = 0; i < number.Length; i += 2)
                {
                    sum += int.Parse(number[i].ToString());
                }
                product *= sum != 0 ? sum : 1;
            }
            transformations++;
            number = product.ToString();
        }



        if (transformations < 10)
        {
            Console.WriteLine(transformations);
        }
        Console.WriteLine(number);
    }
}