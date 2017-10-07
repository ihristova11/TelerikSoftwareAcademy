using System;

class SequencesOfBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number;
        string concat = "";
        string binary = "";
        int zeros = 0;
        int ones = 0;
        int zerosMax = int.MinValue;
        int onesMax = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            binary = Convert.ToString(number, 2);
            concat += new string('0', 30 - binary.Length) + binary;
        }
        for (int j = 1; j < concat.Length; j++)
        {
            if (concat[j - 1] == concat[j])
            { 
                if(concat[j] == '0' )
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }               
            }
            else
            {
                zerosMax = zerosMax < zeros ? zeros : zerosMax;
                onesMax = onesMax < ones ? ones : onesMax;

                ones = 0;
                zeros = 0;
            }
        }
        zerosMax = zerosMax < zeros ? zeros : zerosMax;
        onesMax = onesMax < ones ? ones : onesMax;
        zerosMax = zerosMax == 0 ? 0 : zerosMax + 1;
        onesMax = onesMax == 0 ? 0 : onesMax + 1;
        Console.WriteLine(onesMax);
        Console.WriteLine(zerosMax);
    }
}

