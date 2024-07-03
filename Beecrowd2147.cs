using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int C = int.Parse(Console.ReadLine()); // Número de casos de teste
        double centesimoDeSegundo = 0.01; // Tempo gasto para cada tecla pressionada

        for (int caso = 0; caso < C; caso++)
        {
            string palavra = Console.ReadLine(); // Ler a palavra digitada
            int comprimentoPalavra = palavra.Length; // Obter o comprimento da palavra

            // Calcular o tempo total gasto para digitar a palavra
            double tempoTotal = comprimentoPalavra * centesimoDeSegundo;

            // Imprimir o tempo formatado para duas casas decimais
            Console.WriteLine(tempoTotal.ToString("0.00", CultureInfo.InvariantCulture));
        }
    }
}
