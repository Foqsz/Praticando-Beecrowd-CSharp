using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        double resultado;

        if (N == 0)
        {
            resultado = 3.0;
        }

        else
        {
            resultado = 6.0;
            for (int i = 0; i < N - 1; ++i)
            {
                resultado = 6.0 + 1.0 / resultado;
            }
            resultado = 3.0 + 1.0 / resultado;
        }

        Console.WriteLine(resultado.ToString("N10", CultureInfo.InvariantCulture));
    }
}

