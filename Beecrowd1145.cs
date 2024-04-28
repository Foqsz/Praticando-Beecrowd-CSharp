using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');
            int x = int.Parse(entradas[0]);
            int y = int.Parse(entradas[1]);

            int count = 0; // Usado para controlar a quebra de linha

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);

                count++; // Incrementa o contador

                // Se já foram impressos 3 números, quebra a linha e reseta o contador
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" "); // Adiciona um espaço após cada número, exceto o último
                }
            }

        }
    }
}
