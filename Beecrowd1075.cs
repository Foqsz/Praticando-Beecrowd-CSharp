using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % numero == 2) // para saber os numeros com resto 2
                { 
                    Console.WriteLine(i);
                }

            }
        }
    }
}
