using System;
using System.Text.RegularExpressions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                if (entradas[0].Length > 100 || entradas[2].Length > 100 || !Regex.IsMatch(entradas[0], @"^[a-zA-Z]+$") || !Regex.IsMatch(entradas[2], @"^[a-zA-Z]+$"))
                {
                    break;
                }

                string[] numeros = Console.ReadLine().Split(' ');

                string J1 = entradas[0]; // nome player 1
                string parOrImparJ1 = entradas[1]; // par ou impar player 1
                string J2 = entradas[2]; // nome player 2
                string parOrImparJ2 = entradas[3]; // par ou impar player 2

                int J1N1 = int.Parse(numeros[0]); // numero player 1
                int J2N2 = int.Parse(numeros[1]); // numero player 2

                int soma = J1N1 + J2N2;
                string resultado = soma % 2 == 0 ? "PAR" : "IMPAR";

                if ((parOrImparJ1 == resultado && J1N1 == J1N1) || (parOrImparJ2 == resultado && J2N2 == J2N2))
                {
                    Console.WriteLine(parOrImparJ1 == resultado ? J1 : J2);
                }
            }
        }
    }
}
