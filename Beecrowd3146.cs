using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            //raio(tamanho circulo)
            double tamanhoCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculando a circunferência
            double circunferenciaCirculo = 2 * pi * tamanhoCirculo;
              
            Console.WriteLine(circunferenciaCirculo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
