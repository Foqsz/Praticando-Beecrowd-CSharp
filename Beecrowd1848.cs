using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaGrito = 0;
            int cawCount = 0;

            while (cawCount < 3)
            {
                string entrada = Console.ReadLine();

                if (entrada == "caw caw")
                {
                    Console.WriteLine(somaGrito);
                    somaGrito = 0;
                    cawCount++;
                }
                else
                {
                    int valor = InterpretarPiscada(entrada);
                    somaGrito += valor;
                }
            }
        }

        static int InterpretarPiscada(string piscada)
        {
            int valor = 0;

            if (piscada[0] == '*') valor += 4;
            if (piscada[1] == '*') valor += 2;
            if (piscada[2] == '*') valor += 1;

            return valor;
        }
    }
}
