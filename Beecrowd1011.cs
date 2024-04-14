using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, pi, sum;

            n = double.Parse(Console.ReadLine());
            pi = 3.14159;

            sum = (4.0 / 3) * pi * Math.Pow(n, 3);

            Console.WriteLine("VOLUME = " + sum.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
