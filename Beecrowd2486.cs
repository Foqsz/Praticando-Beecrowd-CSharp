using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Considere que o consumo diário recomendado de vitamina C está entre 110 mg e 130 mg, inclusive.
            int minRecomendado = 110;
            int maxRecomendado = 130; 

            Dictionary<string, int> alimentos = new Dictionary<string, int>()
            {
                { "suco de laranja", 120 },
                { "morango fresco", 85 },
                { "mamao", 85 },
                { "goiaba vermelha", 70 },
                { "manga", 56 },
                { "laranja", 50 },
                { "brocolis", 34 }
            };

            while (true)
            {
                int casosDeTeste = int.Parse(Console.ReadLine());
                if (casosDeTeste == 0) break;

                int totalVitaminaC = 0;

                for (int i = 0; i < casosDeTeste; i++)
                {
                    string[] entrada = Console.ReadLine().Split(' ');
                    int quantidadeAlimento = int.Parse(entrada[0]);
                    string alimento = string.Join(" ", entrada, 1, entrada.Length - 1);


                    totalVitaminaC += quantidadeAlimento * alimentos[alimento];

                }

                if (totalVitaminaC < minRecomendado)
                {
                    int quantoFalta = minRecomendado - totalVitaminaC;
                    Console.WriteLine($"Mais {quantoFalta} mg");
                }
                else if (totalVitaminaC > maxRecomendado)
                {
                    int quantoExcede = totalVitaminaC - maxRecomendado;
                    Console.WriteLine($"Menos {quantoExcede} mg");
                }
                else
                {
                    Console.WriteLine($"{totalVitaminaC} mg");
                }
            }
        }
    }
}
