using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maiorN = int.MinValue;
            int posicaoMaiorN = -1; // Inicializa a posição do maior número como -1 (fora do alcance dos índices válidos)

            for (int i = 0; i < 100; i++) // Começa do índice 0
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada > maiorN)
                {
                    maiorN = entrada;
                    posicaoMaiorN = i + 1; // Atualiza a posição do maior número
                }
            }
            Console.WriteLine(maiorN);
            Console.WriteLine(posicaoMaiorN);
        }
    }
}
