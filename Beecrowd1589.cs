using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int raio;

            for (int i = 0; i < T; i++)
            {
                string[] bobConduite = Console.ReadLine().Split(' ');
                int R1 = int.Parse(bobConduite[0]);
                int R2 = int.Parse(bobConduite[1]);

                raio = R1 + R2;
                Console.WriteLine(raio);
            }
        }
    }
}
