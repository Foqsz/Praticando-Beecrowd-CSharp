using System;
using System.Globalization;
https://judge.beecrowd.com/pt/runs/code/39435695
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int entrada = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < entrada; i++)
            { 
                int n = int.Parse(Console.ReadLine());

                // Verifica se o número é primo utilizando o método NumeroPrimo
                bool primo = NumeroPrimo(n);
                 
                if (primo)
                {
                    Console.WriteLine($"{n} eh primo");
                }
                else
                {
                    Console.WriteLine($"{n} nao eh primo");
                }
            }
        }

        // Método para verificar se um número é primo
        static bool NumeroPrimo(int n)
        {
            // Se o número for menor ou igual a 1, não é primo
            if (n <= 1)
            {
                return false;
            }

            // Verifica divisibilidade do número até a raiz quadrada de n
            for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
            {
                // Se n for divisível por algum divisor diferente de 1 e ele mesmo, não é primo
                if (n % divisor == 0)
                {
                    return false;
                }
            }

            // Se nenhum divisor diferente de 1 e n foi encontrado, então n é primo
            return true;
        }
    }
}
