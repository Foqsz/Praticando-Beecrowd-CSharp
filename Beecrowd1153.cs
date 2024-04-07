using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int n = int.Parse(Console.ReadLine());

            double resultado = CalcularFatorial(n);
            Console.WriteLine(resultado);
        }

        // Função para calcular o fatorial de um número
        static double CalcularFatorial(int numero)
        {
            // Se o número for 0 ou 1, o fatorial é 1, então retorna 1
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                // Se o número for maior que 1, calcula o fatorial
                double fatorial = 1;
                // Utiliza um loop para multiplicar cada número de 2 até 'numero'
                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }
                // Retorna o resultado do fatorial
                return fatorial;
            }
        }
    }
}
