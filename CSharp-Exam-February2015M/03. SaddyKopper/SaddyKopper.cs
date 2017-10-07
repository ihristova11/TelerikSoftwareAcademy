using System;
using System.Text;

class SaddyKopper
{
    static void Main()
    {
        StringBuilder number = new StringBuilder(Console.ReadLine());
        TransformNumber(number);
    }

    static void TransformNumber(StringBuilder number)
    {        
        number.Remove(number.Length - 1, 1);
        //Console.WriteLine(number + " " + number.Length);
        int sum = 0, product = 1, transformations = 0;
        while(number.Length != 0)
        {
            Console.WriteLine("while" + number);
            for (int i = 0; i < number.Length; i += 2)
            {
                Console.WriteLine("for" + number);
                sum += number[i];
            }
            
            number.Remove(number.Length - 1, 1);
            product *= sum;
            sum = 0;
        }
        transformations++;
        number = new StringBuilder(product);
        product = 1;


        if(number.Length == 1)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(number);
        }
        else if(transformations != 10)
        {
            TransformNumber(number);
        }
        else if(transformations == 10)
        {
            Console.WriteLine(number);
        }
    }
}

