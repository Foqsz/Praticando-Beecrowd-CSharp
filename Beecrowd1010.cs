using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
                string[] entradas = Console.ReadLine().Split(' ');
                int codigo = int.Parse(entradas[0]);
                int pecas = int.Parse(entradas[1]);
                double valor = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                string[] entradasDois = Console.ReadLine().Split(' ');
                int codigoDois = int.Parse(entradasDois[0]);
                int pecasDois = int.Parse(entradasDois[1]);
                double valorDois = double.Parse(entradasDois[2], CultureInfo.InvariantCulture);

                double sum = (pecas * valor);
                double sum2 = (pecasDois * valorDois);
                double result = sum + sum2;

                Console.WriteLine("VALOR A PAGAR: R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
             
        }
    }
}
