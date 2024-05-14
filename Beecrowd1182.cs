using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();
             
            double soma = 0;
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    double numero = double.Parse(Console.ReadLine());

                    if (j == C)
                    {
                        soma += numero;
                    }
                }
            }

            if (T == "S")
            {
                Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                soma = soma / 12;
                Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
