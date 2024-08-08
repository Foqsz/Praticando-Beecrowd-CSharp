using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double approximation = 0.0;

            // Comece a calcular a fração continuada de baixo para cima
            for (int i = 0; i < N; i++)
            {
                approximation = 1.0 / (2.0 + approximation);
            }

            // A soma final: 1 + resultado das frações continuadas
            approximation = 1.0 + approximation;

            // Exibe o resultado com 10 casas decimais
            Console.WriteLine(approximation.ToString("F10", CultureInfo.InvariantCulture));
        }
    }
}
