namespace _02.IncreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IncreasingAbsoluteDifferences
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            List<int> numbers;
            List<int> differences = new List<int>();
            bool result = true;
            var diff = 0;
            for (int i = 0; i < t; i++)
            {
                result = true;
                numbers = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 1; j < numbers.Count; j++)
                {
                    differences.Add(numbers[j] < numbers[j - 1] ? numbers[j - 1] - numbers[j] : numbers[j] - numbers[j - 1]);
                }

                for (int k = 1; k < differences.Count; k++)
                {
                    diff = differences[k - 1] < differences[k] ? differences[k] - differences[k - 1] : differences[k - 1] - differences[k];

                    if (differences[k - 1] > differences[k])
                    {
                        result = false;
                        break;
                    }
                    else
                    {
                        if(diff == 0 || diff == 1)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                }

                //Console.WriteLine(string.Join(" ", differences));
                Console.WriteLine(result);
                differences.Clear();
                numbers.Clear();
            }
        }
    }
}
