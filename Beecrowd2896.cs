using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T > 0)
            {
                T--;
                var Ofertas = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = Ofertas[0];
                int K = Ofertas[1];

                int Total = N / K + N % K;
                Console.WriteLine(Total);
            }
        }
    }
}
