using System;
//By @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int[] vet = new int[entrada];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < entrada; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            int menorNumero = vet[0];
            int posicaoMenorNumero = 0;

            for (int i = 1; i < entrada; i++)
            {
                if (vet[i] < menorNumero)
                {
                    menorNumero = vet[i];
                    posicaoMenorNumero = i;
                }
            }

            Console.WriteLine("Menor valor: " + menorNumero);
            Console.WriteLine("Posicao: " + posicaoMenorNumero);
        }
    }
}
