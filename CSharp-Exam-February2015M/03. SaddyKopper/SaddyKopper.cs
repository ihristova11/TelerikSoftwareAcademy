using System;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    public static void Main()
    {
        string number = Console.ReadLine();
        int transformations = 0;
        while (number.Length > 1 && transformations < 10)
        {
            BigInteger product = 1;
            while (number.Length > 0)
            {
                number.Substring(0, number.Length - 1);
                int sum = 0;
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