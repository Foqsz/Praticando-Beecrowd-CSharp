using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            List<int> fibonacciSequence = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                fibonacciSequence.Add(a);
            }

            double binetResult = Binet(n);
            Console.WriteLine(binetResult.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static double Binet(int n)
        {
            return (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);
        }
    }
}
