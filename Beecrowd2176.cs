using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        int P = 0;
        string B = Console.ReadLine();

        for (int i = 0; i < B.Length; ++i)
        {
            P += B[i] == '1' ? 1 : 0;
        }

        Console.WriteLine($"{B}{P % 2}");
    }
}
