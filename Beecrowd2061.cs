using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pericles = Console.ReadLine().Split(' ');
            int N = 0;
            N = int.Parse(pericles[0]);
            int M = int.Parse(pericles[1]);
            int nFinalAbas = N, nClicou = 0, soma = 0, somaDois = 0;

            for (int i = 0; i < M; i++)
            {
                string A = Console.ReadLine();

                if (A == "fechou")
                { 
                    nFinalAbas++;
                    N++;
                }    
                else if (A == "clicou")
                {
                    nClicou++;
                }
            }
            soma = nFinalAbas - nClicou;
            Console.WriteLine(soma);
        }
    }
}
