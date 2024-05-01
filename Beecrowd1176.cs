using System;  
//https://judge.beecrowd.com/pt/runs/code/39436308
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong entrada = ulong.Parse(Console.ReadLine());

            for (ulong i = 0; i < entrada; i++)
            {
                ulong n = ulong.Parse(Console.ReadLine());
                var descobrirFibonnaci = Fibonnaci(n);

                Console.WriteLine($"Fib({n}) = {Fibonnaci(n)}");
            }
        }

        public static ulong Fibonnaci(ulong n)
        {
            ulong a = 0;
            ulong b = 1;
            for (ulong i = 0; i < n; i++)
            {
                ulong temp = a;
                a = b;
                b = temp + b; 
            }
            return a;
        }

    }
}
