using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] somaOg = Console.ReadLine().Split(' ');
                int L = int.Parse(somaOg[0]);
                int R = int.Parse(somaOg[1]);

                if(L == 0 && R == 0) break;

                Console.WriteLine(L + R);
            }
        }
    }
}
