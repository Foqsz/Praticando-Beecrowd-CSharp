using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int entrada = int.Parse(Console.ReadLine());

            int rato = 0;
            int coelho = 0;
            int sapo = 0;
            int cobaias = 0;

            for (int i = 0; i < entrada; i++)
            { 

                string[] animais = Console.ReadLine().Split(' ');
                int quantia = int.Parse(animais[0]);
                string animal = animais[1];

                if (animal == "C")
                {
                    coelho += quantia;
                    cobaias += quantia; // Incrementa a quantidade do animal com a quantidade atual lida na entrada
                }
                else if (animal == "R")
                {
                    rato += quantia;
                    cobaias += quantia; 
                }
                else if (animal == "S")
                {
                    sapo += quantia;
                    cobaias += quantia; 
                }
            }
            double pCoelho, pRato, pSapo;
            pCoelho = ((double)coelho / cobaias) * 100;
            pRato = ((double)rato / cobaias) * 100;
            pSapo = ((double)sapo / cobaias) * 100;

            Console.WriteLine("Total: " + cobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + pCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + pRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + pSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}
