using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] respostas = Console.ReadLine().Split(' ');
            int r1 = int.Parse(respostas[0]);
            int r2 = int.Parse(respostas[1]);
            int r3 = int.Parse(respostas[2]);

            string triste = ":(";
            string feliz = ":)";

            if (r2 < r1 && r3 >= r2)
            {
                Console.WriteLine(feliz);
            }

            else if (r2 > r1 && r3 <= r2)
            {
                Console.WriteLine(triste);
            }

            else if (r2 > r1 && r3 > r2 && r3 - r2 < r2 - r1)
            {
                Console.WriteLine(triste);
            }

            else if (r2 > r1 && r3 > r2 && r3 - r2 >= r2 - r1)
            {
                Console.WriteLine(feliz);
            }

            else if (r2 < r1 && r3 < r2 && r2 - r3 < r1 - r2)
            {
                Console.WriteLine(feliz);
            }

            else if (r2 < r1 && r3 < r2 && r2 - r3 >= r1 - r2)
            {
                Console.WriteLine(triste);
            }

            else if (r1 == r2)
            {
                if (r3 > r2)
                {
                    Console.WriteLine(feliz);
                }
                else
                {
                    Console.WriteLine(triste);
                }
            }
        }
    }
}
 
 
