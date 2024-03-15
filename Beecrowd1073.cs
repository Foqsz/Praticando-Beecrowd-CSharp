using System;
//by @foqsz
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            for (int i = 2; i <= n; i+=2)
            {
                int soma = i * i;
                Console.WriteLine($"{i}^2 = {soma}");
            }
        }
    }
}
