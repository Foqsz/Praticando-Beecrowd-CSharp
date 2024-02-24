using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double soma = N * 60 / 30;

            Console.WriteLine($"{soma} minutos"); 
        }
    }
}
