using System;

class Program
{
    static void Main(string[] args)
    {
        int[] notas = { 2, 5, 10, 20, 50, 100 };

        while (true)
        {
            string[] compras = Console.ReadLine().Split(' ');
            int N = int.Parse(compras[0]);
            int M = int.Parse(compras[1]);

            if (N == 0 && M == 0)
            {
                break;
            }

            int troco = M - N;
            bool possible = false;
 
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = i + 1; j < notas.Length; j++)
                {
                    if (notas[i] + notas[j] == troco)
                    {
                        possible = true;
                        break;
                    }
                }
                if (possible)
                {
                    break;
                }
            }

            if (possible)
            {
                Console.WriteLine("possible");
            }
            else
            {
                Console.WriteLine("impossible");
            }
        }
    }
}
