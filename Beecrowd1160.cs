using System;
using System.Globalization; 
using System.Collections.Generic;

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
                float G1 = float.Parse(casosTeste[2], CultureInfo.InvariantCulture);
                float G2 = float.Parse(casosTeste[3], CultureInfo.InvariantCulture); 
                listTestes.Add(new CasosTeste(PA, PB, G1, G2));


            }
             
            foreach (var CasosTeste in listTestes)
            {
                Console.WriteLine(CasosTeste.SomarCrescimento());
            }


        }

        public class CasosTeste
        {
            public int PA { get; set; }
            public int PB { get; set; }
            public float G1 { get; set; }
            public float G2 { get; set; }

            public CasosTeste(int pA, int pB, float g1, float g2)
            {
                PA = pA;
                PB = pB;
                G1 = g1;
                G2 = g2;
            }

            public string SomarCrescimento()
            {
                int ano = 0;
                while (PA < PB)
                {
                    PA += (int)(PA * (G1 / 100));
                    PB += (int)(PB * (G2 / 100));
                    ano++;

                    if (ano > 100)
                    {
                        return "Mais de 1 seculo.";
                    }
                }
                return ano + " anos.";
            }
        }
    }
}
