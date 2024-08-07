using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double InOne = 234.345;
            double InTwo = 45.698;

            Console.WriteLine($"{InOne.ToString("F6", CultureInfo.InvariantCulture)} - {InTwo.ToString("F6", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F0", CultureInfo.InvariantCulture)} - {InTwo.ToString("F0", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F1", CultureInfo.InvariantCulture)} - {InTwo.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F2", CultureInfo.InvariantCulture)} - {InTwo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F3", CultureInfo.InvariantCulture)} - {InTwo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("e6", CultureInfo.InvariantCulture)} - {InTwo.ToString("e6", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("E6", CultureInfo.InvariantCulture)} - {InTwo.ToString("E6", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F3", CultureInfo.InvariantCulture)} - {InTwo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{InOne.ToString("F3", CultureInfo.InvariantCulture)} - {InTwo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
