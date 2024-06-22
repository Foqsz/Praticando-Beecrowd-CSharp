using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                int n = int.Parse(entrada.Trim());

                if (n < 1) continue;  

                char[,] matriz = new char[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == n / 2 && j == n / 2)
                        {
                            matriz[i, j] = '4';  // Centro da matriz
                        }
                        else if (n / 3 <= i && i < n - n / 3 && n / 3 <= j && j < n - n / 3)
                        {
                            matriz[i, j] = '1';  // Submatriz central
                        }
                        else if (i == j)
                        {
                            matriz[i, j] = '2';  // Diagonal principal
                        }
                        else if (i == n - 1 - j)
                        {
                            matriz[i, j] = '3';  // Diagonal secundária
                        }
                        else
                        {
                            matriz[i, j] = '0';  // Outras posições
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matriz[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
