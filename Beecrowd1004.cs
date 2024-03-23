using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            double sum = a * b;

            Console.WriteLine($"PROD = {sum}");
        }
    }
}
