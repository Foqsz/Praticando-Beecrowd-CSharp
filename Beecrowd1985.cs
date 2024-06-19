using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] produtos = { 1.50, 2.50, 3.50, 4.50, 5.50 };

            Dictionary<int, double> codigoParaPreco = new Dictionary<int, double>
            {
            { 1001, produtos[0] },
            { 1002, produtos[1] },
            { 1003, produtos[2] },
            { 1004, produtos[3] },
            { 1005, produtos[4] }
            };

            int qProdutos = int.Parse(Console.ReadLine());

            double somaCompras = 0;

            for (int i = 0; i < qProdutos; i++)
            {
                string[] compra = Console.ReadLine().Split(' ');
                int produto = int.Parse(compra[0]);
                int quantidade = int.Parse(compra[1]);

                somaCompras += codigoParaPreco[produto] * quantidade;
                
            }
            Console.WriteLine(somaCompras.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
