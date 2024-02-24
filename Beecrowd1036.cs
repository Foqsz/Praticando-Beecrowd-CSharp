using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //math.pow ajuda a calcular ao quadrado
            // formula de bhaskara
            double delta = (Math.Pow(b, 2) - (4 * a * c));

            double R1 = (-b + (Math.Sqrt(delta))) / (2 * a);
            double R2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            if (a != 0 && delta > 0)
            {
                Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
            }

            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }
    }
}
