using System;

namespace _02.NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int len = input.Length;
            int counter = 0;
            int sum = 0;
            int digit;
            bool check = true;
            for (int i = 1; i < len; i+=2)
            {
                check = int.TryParse(input[i].ToString(), out digit);
                if(check)
                {
                    counter++;
                    sum += int.Parse(input[i].ToString());
                }
                
            }
            Console.WriteLine(counter + " " + sum);
        }
    }
}
