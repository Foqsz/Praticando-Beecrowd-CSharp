using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Lê a ordem da matriz
                int N = int.Parse(Console.ReadLine());

                // Se a ordem for 0, termina o programa
                if (N == 0)
                    break;

                // Cria a matriz de ordem N
                int[,] matriz = new int[N, N];

                // Preenche a matriz com valores concêntricos
                for (int camada = 0; camada < (N + 1) / 2; camada++)
                {
                    int valor = camada + 1;

                    // Preenche as bordas da camada
                    for (int i = camada; i < N - camada; i++)
                    {
                        matriz[camada, i] = valor; // Topo
                        matriz[N - camada - 1, i] = valor; // Base
                        matriz[i, camada] = valor; // Esquerda
                        matriz[i, N - camada - 1] = valor; // Direita
                    }
                }

                // Imprime a matriz formatada
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        // Imprime cada elemento da matriz com largura 3
                        Console.Write(matriz[i, j].ToString().PadLeft(3));

                        // Evita espaço extra no final da linha
                        if (j < N - 1)
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                // Imprime uma linha em branco após cada matriz
                Console.WriteLine();
            }
        }
    }
}
