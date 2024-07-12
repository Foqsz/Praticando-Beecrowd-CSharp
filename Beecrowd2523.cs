using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string entrada;
        while ((entrada = Console.ReadLine()) != null)
        {
            entrada = entrada.Trim();
            List<string> lista = new List<string>();

            if (!string.IsNullOrEmpty(entrada))
            { 
                char[] letras = new char[entrada.Length];

                for (int i = 0; i < entrada.Length; i++)
                {
                    letras[i] = entrada[i];  
                    lista.Add(letras[i].ToString());
                }
            }

            List<int> numeros = new List<int>();

            int qntPiscou = int.Parse(Console.ReadLine().Trim());
            string[] nLetraPosicao = Console.ReadLine().Split(' ');

            for (int i = 0; i < qntPiscou; i++)
            {
                int numeroPosicao = int.Parse(nLetraPosicao[i]);
                numeros.Add(numeroPosicao);
            }

            foreach (int num in numeros)
            {
                if (num > 0 && num <= lista.Count)  
                {
                    Console.Write(lista[num - 1]);  
                }
            }

            Console.WriteLine();  
        }
    }
}
