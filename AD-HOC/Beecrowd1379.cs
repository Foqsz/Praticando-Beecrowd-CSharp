using System;
using System.Linq;

namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] calcularMedia = Console.ReadLine().Split(' ');
                int A = int.Parse(calcularMedia[0]);
                int B = int.Parse(calcularMedia[1]);

                if (A == 0 && B == 0) break;

                int C1 = 2 * A - B;
                int C2 = (A + B) / 2;
                int C3 = 2 * B - A;

                int C = Math.Min(Math.Min(C1, C2), C3);

                Console.WriteLine(C);
            }

        }
    }
}
