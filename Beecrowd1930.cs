using System;

class Program
{
    static void Main(string[] args)
    {
        string[] tomadas = Console.ReadLine().Split(' ');
        int T1 = int.Parse(tomadas[0]);
        int T2 = int.Parse(tomadas[1]);
        int T3 = int.Parse(tomadas[2]);
        int T4 = int.Parse(tomadas[3]);

        int soma = (T1 + T2 + T3 + T4) - 3;

        Console.WriteLine(soma);
    }
}
