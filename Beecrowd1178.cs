using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] vet = new decimal[100];
            decimal x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vet[0] = x;

            Console.WriteLine($"N[0] = {Math.Round(vet[0], 4).ToString(CultureInfo.InvariantCulture)}");

            for (int i = 1; i < 100; i++)
            {
                vet[i] = vet[i - 1] / 2;
                Console.WriteLine($"N[{i}] = {Math.Round(vet[i], 4).ToString(CultureInfo.InvariantCulture)}");
            }
        }
    }
}
