using System;

class Program
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int L1 = (L * C) + ((L - 1) * (C - 1));
        int L2 = ((L - 1) * 2) + ((C - 1) * 2);

        Console.WriteLine(L1);
        Console.WriteLine(L2);

    }
}
