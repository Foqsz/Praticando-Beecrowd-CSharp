using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');
        int S = int.Parse(entradas[0]);
        int T = int.Parse(entradas[1]);
        int F = int.Parse(entradas[2]);

        int resultado = S + T + F;

        if (resultado >= 24)
        {
            resultado -= 24;
        }
        else if (resultado < 0)
        {
            resultado += 24;
        }

        Console.WriteLine(resultado);
    }
}
