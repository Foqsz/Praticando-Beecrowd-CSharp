using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int somaDomino;

            somaDomino = ((N + 1) * (N + 2)) / 2;

            Console.WriteLine(somaDomino);
        }
    }
}
