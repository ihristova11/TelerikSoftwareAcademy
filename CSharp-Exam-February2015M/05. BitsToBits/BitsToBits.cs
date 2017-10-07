using System;

class BitsToBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number;
        string concat = "";
        string binary = "";
        int zeros_max = int.MinValue;
        int ones_max = int.MinValue;
        int zeros = 0;
        int ones = 0;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            binary = Convert.ToString(number, 2);
            concat += new string('0', 30 - binary.Length) + binary;
        }
        //Console.WriteLine(concat);

        for (int j = 1; j < concat.Length; j++)
        {
            if (concat[j - 1] == concat[j])
            {
                //zeros++;
                if (concat[j] == '0')
                {
                    zeros++;
                }
                else if (concat[j] == '1')
                {
                    ones++;
                }
            }
            else
            {
                ones_max = (ones_max < ones) ? ones : ones_max;
                zeros_max = (zeros_max < zeros) ? zeros : zeros_max;
                
                zeros = 0;
                ones = 0;
            }

            
        }
        ones_max = (ones_max < ones) ? ones : ones_max;
        zeros_max = (zeros_max < zeros) ? zeros : zeros_max;
        zeros_max = zeros_max == 0 ? 0 : zeros_max + 1;
        ones_max = ones_max == 0 ? 0 : ones_max + 1;


        Console.WriteLine(zeros_max);
        Console.WriteLine(ones_max);
    }
}

