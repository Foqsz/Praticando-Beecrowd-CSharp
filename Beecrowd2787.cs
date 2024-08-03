using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhasTabuleiro = int.Parse(Console.ReadLine());
            int colunasTabuleiro = int.Parse(Console.ReadLine());

            Console.WriteLine((linhasTabuleiro + colunasTabuleiro) % 2 == 0 ? "1" : "0");

        }
    }
}
