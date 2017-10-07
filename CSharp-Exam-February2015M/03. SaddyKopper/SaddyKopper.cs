using System;
using System.Text;

class SaddyKopper
{
    static void Main()
    {
        //StringBuilder number = new StringBuilder(Console.ReadLine());

        //Console.WriteLine(number);
        TransformNumber();

    }

    static void TransformNumber()
    {
        StringBuilder number = new StringBuilder(Console.ReadLine());
        number.Remove(number.Length - 1, 1);
        Console.WriteLine(number + " " + number.Length);
        int sum = 0, product = 1, transformations = 1;
        while(number.Length != 0)
        {
            for (int i = 0; i < number.Length; i += 2)
            {
                sum += number[i];
            }
            product *= sum;
            sum = 0;
        }       
    }
}

