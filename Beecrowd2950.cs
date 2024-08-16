using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] distancias = Console.ReadLine().Split(' ');
            decimal distanciaPalantir = decimal.Parse(distancias[0]);
            decimal diamatroPalantir = decimal.Parse(distancias[1]);
            decimal diametroPalantirSaruman = decimal.Parse(distancias[2]);

            decimal valorICM = distanciaPalantir / (diamatroPalantir + diametroPalantirSaruman);

            Console.WriteLine(valorICM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
