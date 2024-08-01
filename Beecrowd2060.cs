using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] Bino = Console.ReadLine().Split(' ');
            int M2 = 0, M3 = 0, M4 = 0, M5 = 0;

            for (int i = 0; i < N; i++)
            {
                int DesafioBino = int.Parse(Bino[i]);

                if(DesafioBino % 2 == 0) { M2++; }
                if(DesafioBino % 3 == 0) { M3++; }
                if(DesafioBino % 4 == 0) { M4++; }
                if(DesafioBino % 5 == 0) { M5++; }

            }

            Console.WriteLine($"{M2} Multiplo(s) de 2");
            Console.WriteLine($"{M3} Multiplo(s) de 3");
            Console.WriteLine($"{M4} Multiplo(s) de 4");
            Console.WriteLine($"{M5} Multiplo(s) de 5");

        }

    }
}
