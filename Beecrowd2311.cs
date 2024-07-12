using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    { 
        int nCompetidores = int.Parse(Console.ReadLine());

        for (int i = 0; i < nCompetidores; i++)
        {
            string nomeCompetidor = Console.ReadLine();
            decimal grauDificuldade = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] notaJuizes = Console.ReadLine().Split(' ');
            List<decimal> list = new List<decimal>();
            for (int j = 0; j < 7; j++)
            {
                decimal notasArmazenadas = decimal.Parse(notaJuizes[j], CultureInfo.InvariantCulture);
                list.Add(notasArmazenadas);
            }

            decimal menorNota = list.Min();
            decimal maiorNota = list.Max();
            decimal somaFinal = (list.Sum() - menorNota - maiorNota) * grauDificuldade;
            Console.WriteLine($"{nomeCompetidor} {somaFinal.ToString("F2", CultureInfo.InvariantCulture)}");  
        }  
    }
}

