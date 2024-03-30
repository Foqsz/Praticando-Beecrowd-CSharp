using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] quadrantes = Console.ReadLine().Split(' ');
                int x = int.Parse(quadrantes[0]);
                int y = int.Parse(quadrantes[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x == 0)
                {
                    break;
                }
               
            }
        }
    }
}
