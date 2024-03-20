using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double resultado = a + b;
            Console.WriteLine("SOMA = " + resultado);
        }
    }
}
