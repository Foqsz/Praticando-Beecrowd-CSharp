using System;

class Program
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();

        if (S.Length <= 80)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

