using System;

namespace Course  
{
    class Program  
    {
        static void Main(string[] args)  
        {
            int N = int.Parse(Console.ReadLine());  
 
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');  
                int X = int.Parse(valores[0]);  
                int Y = int.Parse(valores[1]);  

                int somaImpares = SomaImparesEntre(X, Y); // Chama a função para calcular a soma de números ímpares entre X e Y
                Console.WriteLine(somaImpares);  
            }
        }

        static int SomaImparesEntre(int X, int Y) // Função para calcular a soma de números ímpares entre X e Y
        {
            int soma = 0; // Inicializa a variável soma

            // Loop para percorrer os números entre X e Y (exclusivo)
            for (int j = Math.Min(X, Y) + 1; j < Math.Max(X, Y); j++)
            {
                if (j % 2 != 0) // Verifica se o número é ímpar
                {
                    soma += j; // Se for ímpar, adiciona-o à soma
                }
            }

            return soma;  
        }
    }
}
