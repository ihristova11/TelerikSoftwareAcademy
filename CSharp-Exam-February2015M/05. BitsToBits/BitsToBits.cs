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
        int zeros = 1;
        int ones = 1;
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
                
                zeros = 1;
                ones = 1;
            }

            
        }
        ones_max = (ones_max < ones) ? ones : ones_max;
        zeros_max = (zeros_max < zeros) ? zeros : zeros_max;

        //Console.WriteLine("zeros: " + zeros);
        //Console.WriteLine("ones: " + ones);
        //Console.WriteLine("maxZ: " + zeros_max);
        //Console.WriteLine("maxO: " + ones_max);
        //Console.WriteLine("-----------------");

        Console.WriteLine(zeros_max);
        Console.WriteLine(ones_max);
    }
}

