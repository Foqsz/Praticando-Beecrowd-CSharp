using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media1, media2;

            media1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaFinal = ((media1 * 3.5) + (media2 * 7.5)) / (3.5 + 7.5);

            Console.WriteLine($"MEDIA = {mediaFinal.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
