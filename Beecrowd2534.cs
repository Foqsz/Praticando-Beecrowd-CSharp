using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input == null)
            {
                break;
            }

            string[] exames = input.Split(' ');
            int N = int.Parse(exames[0]);  
            int Q = int.Parse(exames[1]);  

            List<int> notasList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int valorNota = int.Parse(Console.ReadLine());
                notasList.Add(valorNota);
            }
             
            notasList.Sort((a, b) => b.CompareTo(a));

            List<int> consultasList = new List<int>();

            for (int j = 0; j < Q; j++)
            {
                int valorConsulta = int.Parse(Console.ReadLine());
                consultasList.Add(valorConsulta);
            }
             
            foreach (int indiceConsulta in consultasList)
            {
                if (indiceConsulta > 0 && indiceConsulta <= notasList.Count)
                {
                    Console.WriteLine(notasList[indiceConsulta - 1]);
                }
            }
        }
    }
}
