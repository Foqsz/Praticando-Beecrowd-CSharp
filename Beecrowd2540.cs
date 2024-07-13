using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int nJogadores = int.Parse(entrada);
            List<int> numeros = new List<int>();

            string[] numerosVotacao = Console.ReadLine().Split(' ');
            for (int i = 0; i < nJogadores; i++)
            {
                int nVotos = int.Parse(numerosVotacao[i]);
                numeros.Add(nVotos);
            }

            double doisTercos = (2.0 / 3.0) * nJogadores;

            if (numeros.Sum() >= doisTercos)
            {
                Console.WriteLine("impeachment");
            }
            else
            {
                Console.WriteLine("acusacao arquivada");
            }
        }
    }
}
