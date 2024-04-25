using System;  
using System.Globalization;  

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            double S = 1; // Inicialização da variável S com o valor inicial de 1

            // Loop que itera de 2 a 100 para calcular a soma dos termos da série
            for (int i = 2; i <= 100; i++)
            {
                S += 1.0 / i; // Adiciona o inverso de cada número à variável S
              //1.0 / i: Isso calcula o inverso do valor atual de i. Como i é um número inteiro que está sendo incrementado de 2 até 100, 1.0 / i calculará o inverso de cada número, começando com 1/2, depois 1/3, e assim por diante até 1/100.
              //S +=: Isso é um operador de atribuição composto. Ele adiciona o valor à direita do operador ao valor atual de S e, em seguida, armazena o resultado em S. Então, S += 1.0 / i; está adicionando o valor calculado 1.0 / i à variável S.
            }
   
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
