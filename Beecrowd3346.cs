using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PIB = Console.ReadLine().Split(' ');
            double floatPibOne = double.Parse(PIB[0], CultureInfo.InvariantCulture);
            double floatPibTwo = double.Parse(PIB[1], CultureInfo.InvariantCulture);

            double resultFloatPib = ((1 + floatPibOne / 100) * (1 + floatPibTwo / 100) - 1) * 100;

            Console.WriteLine(resultFloatPib.ToString("F6", CultureInfo.InvariantCulture));


        }
    }
}
