using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int nAlunos = int.Parse(Console.ReadLine());

        List<Tuple<int, double>> alunos = new List<Tuple<int, double>>();
        double maiorNota = double.MinValue;
        int matriculaMaiorNota = 0;

        for (int i = 0; i < nAlunos; i++)
        {
            string[] notaAlunos = Console.ReadLine().Split(' ');

            if (notaAlunos.Length >= 2)
            { 
                int nMatricula = int.Parse(notaAlunos[0]);
                double nNotas = double.Parse(notaAlunos[1], CultureInfo.InvariantCulture);
                alunos.Add(new Tuple<int, double>(nMatricula, nNotas));

                if (nNotas > maiorNota)
                {
                    maiorNota = nNotas;  
                    matriculaMaiorNota = nMatricula;  
                }
            }

        }

        bool notaMinimaAlcancada = false;

        foreach (var aluno in alunos)
        {
            if (aluno.Item2 >= 8.0)
            {
                notaMinimaAlcancada = true;
                break;  
            }
        }
         
        if (notaMinimaAlcancada)
        {
            Console.WriteLine(matriculaMaiorNota);
        }
        else
        {
            Console.WriteLine("Minimum note not reached");
        }
    }
}

