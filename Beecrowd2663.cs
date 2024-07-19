using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
        int nCompetidores = int.Parse(Console.ReadLine());
         
        int minClassificados = int.Parse(Console.ReadLine());
         
        List<int> pontuacoes = new List<int>();
         
        for (int i = 0; i < nCompetidores; i++)
        {
            int pontuacao = int.Parse(Console.ReadLine());
            pontuacoes.Add(pontuacao);
        }

        // Ordenação das pontuações em ordem decrescente
        pontuacoes.Sort((a, b) => b.CompareTo(a));

        // Encontrar a pontuação do K-ésimo competidor (minClassificados - 1 porque é zero-indexed)
        int pontuacaoCorte = pontuacoes[minClassificados - 1];

        // Contar quantos competidores têm pontuação maior ou igual à pontuação de corte
        int count = 0;
        foreach (int pontuacao in pontuacoes)
        {
            if (pontuacao >= pontuacaoCorte)
            {
                count++;
            }
        } 
        Console.WriteLine(count);
    }
}
