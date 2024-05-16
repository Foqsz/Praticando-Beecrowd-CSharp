using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            string O = Console.ReadLine();
             
            double soma = 0;
            int elementos = 0;
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    double numero = double.Parse(Console.ReadLine());
                    //i = amarelo
                    //j = verde
                    if((i < 6 && j > 11 - i) || (i > 5 && j > i))
                    {
                        soma += numero;
                        elementos++;
                    }
                }
            }

            if (O == "S")
            {
                Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                soma = soma / elementos;
                Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
