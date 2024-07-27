using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string entrada = Console.ReadLine();
                string resultado = PlacaSP(entrada);
                Console.WriteLine(resultado);
            }
        }

        static string PlacaSP(string placa)
        {
            // Verifica se a placa está no formato correto usando Regex
            if (!Regex.IsMatch(placa, "^[A-Z]{3}-[0-9]{4}$"))
            {
                return "FAILURE";
            }

            // Obtém o último dígito da placa
            char lastDigit = placa[placa.Length - 1];

            // Dicionário que mapeia os dias da semana aos dígitos finais da placa
            Dictionary<char, string> diaSemana = new Dictionary<char, string>
            {
                {'1', "MONDAY"},
                {'2', "MONDAY"},
                {'3', "TUESDAY"},
                {'4', "TUESDAY"},
                {'5', "WEDNESDAY"},
                {'6', "WEDNESDAY"},
                {'7', "THURSDAY"},
                {'8', "THURSDAY"},
                {'9', "FRIDAY"},
                {'0', "FRIDAY"}
            };

            // Retorna o dia correspondente ao último dígito da placa
            if (diaSemana.ContainsKey(lastDigit))
            {
                return diaSemana[lastDigit];
            }
            else
            {
                return "FAILURE";
            }
        }
    }
}
