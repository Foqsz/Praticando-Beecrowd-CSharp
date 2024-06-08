using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                // Verifica se a entrada é null (EOF)
                if (input == null)
                {
                    break;
                }

                string[] cartas = input.Split(':');
                int H = int.Parse(cartas[0]);
                int M = int.Parse(cartas[1]);

                if (H >= 5 && H <= 6)
                {
                    Console.WriteLine($"Atraso maximo: 0");
                }
                else if (H == 7)
                {
                    Console.WriteLine($"Atraso maximo: {M}");
                }
                else if (H == 8)
                {
                    Console.WriteLine($"Atraso maximo: {60 + M}");
                }
                else
                {
                    Console.WriteLine($"Atraso maximo: {120 + M}");
                }
            }
        }
    }
}
