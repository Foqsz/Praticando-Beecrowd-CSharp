using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double N = double.Parse(Console.ReadLine());

        double ln = Math.Log(N);

        double inferior = N / ln;
        double superior = 1.25506 * N / ln;

        Console.WriteLine($"{inferior.ToString("F1", CultureInfo.InvariantCulture)} {superior.ToString("F1", CultureInfo.InvariantCulture)}");

    }
}
