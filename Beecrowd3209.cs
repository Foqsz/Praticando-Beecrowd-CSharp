using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosTeste; i++)
            { 
                var tomadaEletrica = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                 
                int nCasosTomadas = tomadaEletrica.Length;
                 
                int somaTomadas = tomadaEletrica.Sum() - (nCasosTomadas - 1);
                 
                Console.WriteLine((somaTomadas - tomadaEletrica[0]) + 1);
            }
        }
    }
}
