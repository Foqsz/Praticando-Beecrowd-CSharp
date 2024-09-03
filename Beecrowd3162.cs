using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int navesParaAnalisar = int.Parse(Console.ReadLine());
            var naves = new (double x, double y, double z)[navesParaAnalisar];
             
            for (int i = 0; i < navesParaAnalisar; i++)
            {
                var coords = Console.ReadLine().Split(' ');
                naves[i] =
                    (
                        double.Parse(coords[0], CultureInfo.InvariantCulture),
                        double.Parse(coords[1], CultureInfo.InvariantCulture),
                        double.Parse(coords[2], CultureInfo.InvariantCulture)
                    );
            }
 
            for (int i = 0; i < navesParaAnalisar; i++)
            {
                double menorDistancia = double.MaxValue;

                for (int j = 0; j < navesParaAnalisar; j++)
                {
                    if (i != j)
                    {
                        double distancia = CalcularDistancia(naves[i], naves[j]);

                        if (distancia < menorDistancia)
                        {
                            menorDistancia = distancia;
                        }
                    }
                }

                string intensidade = DeterminarIntensidade(menorDistancia);
                Console.WriteLine(intensidade);
            }
        }

        static double CalcularDistancia((double x, double y, double z) p1, (double x, double y, double z) p2)
        {
            return Math.Sqrt(
                Math.Pow(p2.x - p1.x, 2) +
                Math.Pow(p2.y - p1.y, 2) +
                Math.Pow(p2.z - p1.z, 2)
            );
        }
        //de modo que naves que distam entre si até 20 u.m. possuem uma intensidade alta; acima de 20 u.m. e até 50 u.m.
        //possuem uma intensidade média; enquanto a intensidade do sinal acima de 50 u.m. é tão baixa que não possibilita a comunicação entre as naves.
        static string DeterminarIntensidade(double distancia)
        {
            if (distancia <= 20)
                return "A";
            else if (distancia > 20 && distancia <= 50)
                return "M";
            else
                return "B";
        }
    }
}
