using System;
using System.Linq;
namespace _11.AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] coeff1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] coeff2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Sum(coeff1, coeff2, n);
        }

        static void Sum(int[] arr1, int[] arr2, int n)
        {
            int[] sum = new int[n];
            for (int i = 0; i < n; i++)
            {
                sum[i] = arr1[i] + arr2[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
