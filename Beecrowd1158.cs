using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int caso = 0; caso < N; caso++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                int soma = 0;
                int count = 0;
                while (count < Y)
                {
                    if (X % 2 != 0)
                    {
                        soma += X;
                        count++;
                    }
                    X++;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
