using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        // Função para calcular a sequência triangular aumentada
        static int SequenciaN(int nFoqs)
        { 
            return (nFoqs * (nFoqs + 1)) / 2;
        }

        static void Main(string[] args)
        {  
            int numeroCaso = 1;
            string entrada;

            // Loop para ler todas as linhas da entrada padrão até não haver mais linhas
            while ((entrada = Console.ReadLine()) != null)
            {
                // Converte a entrada para um número inteiro
                int n = int.Parse(entrada.Trim());

                // Imprime o número do caso e o resultado da sequência triangular aumentada
                Console.WriteLine($"Caso {numeroCaso++}: {SequenciaN(n) + 1} numero{(n == 0 ? "" : "s")}");

                // Lista para armazenar os números a serem impressos
                List<int> solutions = new List<int>();
                solutions.Add(0); // Adiciona o número 0 à lista
                 
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        solutions.Add(i); // Adiciona 'i' à lista 'n' vezes
                    }
                }

                // Imprime a lista de números separados por espaço
                Console.WriteLine(string.Join(" ", solutions));
                 
                Console.WriteLine("");
            }
        }
    }
}
