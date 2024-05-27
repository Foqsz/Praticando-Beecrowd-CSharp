using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] casa = Console.ReadLine().Split(' ');

                if (casa.Length != 3) //caso a entrada nao tenha tres numeros separados por espaço
                {
                    break;
                }

                int A = int.Parse(casa[0]);
                int B = int.Parse(casa[1]);
                int C = int.Parse(casa[2]);

                if (A == 0 ||  B == 0 || C == 0)
                {
                    break;
                }

                double areaCasa, ladoTerreno, areaMaxima;
                areaCasa = A * B;
                areaMaxima = areaCasa / (C / 100.0);
                ladoTerreno = Math.Sqrt(areaMaxima);

                Console.WriteLine(Math.Floor(ladoTerreno));
            }
        }
    }
}
