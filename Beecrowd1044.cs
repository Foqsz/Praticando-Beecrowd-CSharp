using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] multiplos = Console.ReadLine().Split(' ');
            int a = int.Parse(multiplos[0]);
            int b = int.Parse(multiplos[1]);

            if (a % b == 0 || b % a == 0) // aqui somamos se são multiplos
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos ");
            }
        }
    }
}
