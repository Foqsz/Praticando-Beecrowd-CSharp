//https://judge.beecrowd.com/pt/runs/code/39434435

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CasosTeste> listTestes = new List<CasosTeste>();

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] casosTeste = Console.ReadLine().Split(' ');
                int PA = int.Parse(casosTeste[0]);
                int PB = int.Parse(casosTeste[1]);
                double G1 = double.Parse(casosTeste[2], CultureInfo.InvariantCulture);
                double G2 = double.Parse(casosTeste[3], CultureInfo.InvariantCulture);
                listTestes.Add(new CasosTeste(PA, PB, G1, G2));
            }

            foreach (var casosTeste in listTestes)
            {
                Console.WriteLine(casosTeste.SomarCrescimento());
            }
        }

        public class CasosTeste
        {
            public int PA { get; set; }
            public int PB { get; set; }
            public double G1 { get; set; }
            public double G2 { get; set; }

            public CasosTeste(int pA, int pB, double g1, double g2)
            {
                PA = pA;
                PB = pB;
                G1 = g1;
                G2 = g2;
            }

            public string SomarCrescimento()
            {
                int anos;
                for (anos = 1; PA <= PB && anos < 101; ++anos)
                {
                    PA += (int)(PA * G1 / 100);
                    PB += (int)(PB * G2 / 100);
                }

                if (PA <= PB)
                {
                    return "Mais de 1 seculo.";
                }
                else
                {
                    return $"{anos - 1} anos.";
                }
            }
        }
    }
}
