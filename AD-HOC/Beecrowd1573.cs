using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int C = int.Parse(input[2]);

                if (A == 0 && B == 0 && C == 0) break;

                int arestasParalepipedo = A * B * C;
                double s = (int)Math.Floor(Math.Pow(arestasParalepipedo, 1.0 / 3.0));
                //Math.Pow para a raiz cúbica.
                //Math.Pow(base, expoente) é uma função que calcula a potência de um número. O primeiro argumento é a base e o segundo é o expoente.
                //A função Math.Floor(x) arredonda o número x para baixo, ou seja, retorna o maior inteiro menor ou igual a x.
                Console.WriteLine(s);
            }

        }
    }
}
