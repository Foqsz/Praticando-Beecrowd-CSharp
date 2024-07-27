using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFigurinhas = int.Parse(Console.ReadLine());
            int figurinhasCompradas = int.Parse(Console.ReadLine());

            List<int> figures = new List<int>();    

            for (int i = 0; i < figurinhasCompradas; i++)
            {
                int figurinha = int.Parse(Console.ReadLine());
                figures.Add(figurinha);
            }

            List<int> contarFigurinhas = figures.Distinct().ToList();

            int somarResultadoFinal = contarFigurinhas.Count() - totalFigurinhas;
            Console.WriteLine(Math.Abs(somarResultadoFinal));
        } 
    }
}
