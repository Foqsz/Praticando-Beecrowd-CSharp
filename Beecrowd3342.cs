using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = n * n;

            double pecasPretas = (n * n) / 2;
            double pecasBrancas = (n * n) / 2;

            if (sum % 2 != 0)
            {
                pecasBrancas++;
            }

            Console.WriteLine($"{pecasBrancas} casas brancas e {pecasPretas} casas pretas");
        }
    }
}
