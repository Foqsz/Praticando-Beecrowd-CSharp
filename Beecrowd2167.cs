using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        string[] motores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            int R = int.Parse(motores[i]);
            list.Add(R);
        }

        int cont = 0;
        for (int i = 1; i < N; i++)
        {
            if (list[i] < list[i - 1])
            {
                cont = i + 1;
                break;
            }
        }

        Console.WriteLine(cont);
    }
}
