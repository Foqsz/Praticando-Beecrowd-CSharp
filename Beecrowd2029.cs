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

                double altura = CalcularAltura(V, D);
                double area = CalcularArea(D);

                Console.WriteLine("ALTURA = " + altura.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture)); 
            }
        }

        static double CalcularAltura(double V, double D)
        {
            double raio = D / 2.0;
            double areaBase = 3.14 * Math.Pow(raio, 2); // Usando PI aproximado como 3.14
            double altura = V / areaBase;

            return altura;  
        }

        static double CalcularArea(double D)
        {
            double raio = D / 2.0;
            double area = 3.14 * Math.Pow(raio, 2); // Usando PI aproximado como 3.14

            return area;  
        }
    }
}
