using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                double V = double.Parse(input, CultureInfo.InvariantCulture);
                double D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

                Console.WriteLine("ALTURA = " + CalcularAltura(V, D).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("AREA = " + CalcularArea(D).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
        }

        static double CalcularAltura(double V, double D)
        {
            double raio = D / 2.0;
            double areaBase = Math.PI * Math.Pow(raio, 2);
            double altura = V / areaBase;

            return altura;
        }

        static double CalcularArea(double D)
        {
            double raio = D / 2.0;
            double area = Math.PI * Math.Pow(raio, 2);

            return area;
        }
    }
}
