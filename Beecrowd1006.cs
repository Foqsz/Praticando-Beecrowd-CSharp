using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media1, media2, media3, mediaFinal;

            media1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media3 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaFinal = ((media1 * 2) + (media2 * 3) + (media3 * 5)) / (2 + 3 + 5);

            Console.WriteLine($"MEDIA = {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
