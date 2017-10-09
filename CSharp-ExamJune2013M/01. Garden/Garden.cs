using System;

class Garden
{
    static void Main()
    {
        double costs = 0;
        int area = 250;
        bool insufficient = false;
        for (int i = 1; i <= 11; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                switch (i)
                {
                    case 1:
                        costs += input * 0.5;
                        break;
                    case 3:
                        costs += input * 0.4;
                        break;
                    case 5:
                        costs += input * 0.25;
                        break;
                    case 7:
                        costs += input * 0.6;
                        break;
                    case 9:
                        costs += input * 0.3;
                        break;
                    case 11:
                        costs += input * 0.4;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                area -= input;
                if(area < 0)
                {
                    insufficient = true;
                }
            }
        }

        Console.WriteLine("Total costs: {0:f2}", costs);
        if (insufficient)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (area == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", area);
        }
    }
}

