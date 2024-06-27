using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int P = int.Parse(entrada[0]);
        int N = int.Parse(entrada[1]);

        string[] alturasString = Console.ReadLine().Split(' ');
        int[] alturas = new int[N];
        for (int i = 0; i < N; i++)
        {
            alturas[i] = int.Parse(alturasString[i]);
        }

        bool podeVencer = true;
        for (int i = 0; i < N - 1; i++)
        {
            int diferenca = Math.Abs(alturas[i] - alturas[i + 1]);
            if (diferenca > P)
            {
                podeVencer = false;
                break;
            }
        }

        if (podeVencer)
        {
            Console.WriteLine("YOU WIN");
        }
        else
        {
            Console.WriteLine("GAME OVER");
        }
    }
}

