using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numeros = new List<double>();

            while (true)
            {
                double entrada = double.Parse(Console.ReadLine());

                if (entrada <= 0)
                {
                    if (numeros.Count > 0)
                    {
                        double soma = 0;
                        foreach (double numero in numeros)
                        {
                            soma += numero;
                        }
                        double media = soma / numeros.Count;
                        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    break;
                }

                numeros.Add(entrada);
            }
        }
    }
}
