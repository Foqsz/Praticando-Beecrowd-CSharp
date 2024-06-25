using System;

class Program
{
    static void Main(string[] args)
    {
        int C = int.Parse(Console.ReadLine());

        for (int i = 0; i < C; i++)
        {
            int N = int.Parse(Console.ReadLine());

            int S = N % 2 != 0 ? 1 : 0;    
            Console.WriteLine(S);
        }
    }
}
