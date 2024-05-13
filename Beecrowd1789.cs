using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            while (true)
            {
                string iniciar = Console.ReadLine();
                if (iniciar == null)
                    break;

                int entrada = int.Parse(iniciar);

                string[] valores = Console.ReadLine().Split(' ');

                List<Lesmas> list = new List<Lesmas>();

                for (int i = 0; i < entrada; i++)
                {
                    int V = int.Parse(valores[i]);
                    list.Add(new Lesmas(V));
                }

                int maiorVelocidade = int.MinValue;

                foreach (var vLesmas in list)
                {
                    if (vLesmas.VelLesma > maiorVelocidade)
                    {
                        maiorVelocidade = vLesmas.VelLesma;
                    }
                }

                if (maiorVelocidade < n1)
                {
                    Console.WriteLine("1");
                }
                else if (maiorVelocidade >= n1 && maiorVelocidade < n2)
                {
                    Console.WriteLine("2");
                }
                else if (maiorVelocidade >= n2)
                {
                    Console.WriteLine("3");
                }
            }
        }

        public class Lesmas
        {
            public int VelLesma { get; set; }

            public Lesmas(int velLesma)
            {
                VelLesma = velLesma;
            }
        }
    }
}
