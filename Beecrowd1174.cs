using System;
using System.Globalization;
//https://judge.beecrowd.com/pt/runs/code/39435180
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[100];
            double negativos;
            for (int i = 0; i < 100; i++)
            {
                double x = double.Parse(Console.ReadLine());
                A[i] = x;

                if (x <= 10)
                {
                    negativos = A[i];
                    Console.WriteLine($"A[{i}] = {negativos.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            } 
        }
    }
}
