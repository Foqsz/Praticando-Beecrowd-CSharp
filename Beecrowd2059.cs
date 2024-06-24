using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');
        int p = int.Parse(entradas[0]);
        int j1 = int.Parse(entradas[1]);
        int j2 = int.Parse(entradas[2]);
        int r = int.Parse(entradas[3]);
        int a = int.Parse(entradas[4]);

        // Caso de roubo
        if (r == 1)
        {
            if (a == 1)
            {
                // Jogador 1 roubou e foi acusado
                Console.WriteLine("Jogador 2 ganha!");
            }
            else
            {
                // Jogador 1 roubou e não foi acusado
                Console.WriteLine("Jogador 1 ganha!");
            }
        }
        else
        {
            if (a == 1)
            {
                // Jogador 1 não roubou e foi acusado
                Console.WriteLine("Jogador 1 ganha!");
            }
            else
            {
                // Sem roubo e sem acusação, jogo normal de par ou ímpar
                int soma = j1 + j2;
                bool somaPar = (soma % 2 == 0);

                if ((p == 1 && somaPar) || (p == 0 && !somaPar))
                {
                    Console.WriteLine("Jogador 1 ganha!");
                }
                else
                {
                    Console.WriteLine("Jogador 2 ganha!");
                }
            }
        }
    }
}
