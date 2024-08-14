using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Jornada = Console.ReadLine().Split(' ');
            decimal quantidadeAnoes = int.Parse(Jornada[0]);
            decimal distanciaVila = int.Parse(Jornada[1]);

            decimal saberDistancia = distanciaVila / (quantidadeAnoes + 2);

            Console.WriteLine(saberDistancia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
