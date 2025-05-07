using System;

namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            int colocacao = int.Parse(Console.ReadLine());

            if (colocacao == 1) { Console.WriteLine("Top 1"); }
            else if (colocacao >= 2 && colocacao <= 3) { Console.WriteLine("Top 3"); }
            else if (colocacao >= 4 && colocacao <= 5) { Console.WriteLine("Top 5"); }
            else if (colocacao >= 6 && colocacao <= 10) { Console.WriteLine("Top 10"); }
            else if (colocacao >= 11 && colocacao <= 25) { Console.WriteLine("Top 25"); }
            else if (colocacao >= 26 && colocacao <= 50) { Console.WriteLine("Top 50"); }
            else
            {
                Console.WriteLine("Top 100");

            }
        }
    }
}
