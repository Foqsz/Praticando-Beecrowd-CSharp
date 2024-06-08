using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cartas = Console.ReadLine().Split(' ');
            int A = int.Parse(cartas[0]);
            int B = int.Parse(cartas[1]);

            //Um trio(três cartas de mesmo valor) ganha de uma dupla(duas cartas de mesmo valor).
            //Um trio formado por cartas de maior valor ganha de um trio formado por cartas de menor valor.
            //Uma dupla formada por cartas de maior valor ganha de uma dupla formada por cartas de menor valor.

            if (A == B && B == A)
            {
                Console.WriteLine(A);
            }

            else if (A > B)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}
