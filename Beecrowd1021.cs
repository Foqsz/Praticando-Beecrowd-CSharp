using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {  
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            decimal valorDigitado = decimal.Parse(Console.ReadLine() ?? "0");

            int centavos = Convert.ToInt32(valorDigitado * 100);

            decimal[] notas = { 100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M };
            decimal[] moedas = { 1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };

            Console.WriteLine("NOTAS:");

            foreach (decimal nota in notas)
            {
                int notaConvertida = Convert.ToInt32(nota * 100);
                int quantdidadeDeNotas = centavos / notaConvertida;

                Console.WriteLine($"{quantdidadeDeNotas} nota(s) de R$ {nota}");

                centavos %= notaConvertida;

            }

            Console.WriteLine("MOEDAS:");

            foreach (decimal moeda in moedas)
            {
                int moedaConvertida = Convert.ToInt32(moeda * 100);
                int quantdidadeDeMoedas = centavos / moedaConvertida;

                Console.WriteLine($"{quantdidadeDeMoedas} moeda(s) de R$ {moeda}");

                centavos %= moedaConvertida;

            }

        }
    }
}

// aula: https://www.youtube.com/watch?v=OG_F-lfQNWQ&ab_channel=MZdevelopment
