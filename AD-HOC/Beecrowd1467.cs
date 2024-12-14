using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                string[] ZerinhoOrOne = entrada.Split(' ');
                int A = int.Parse(ZerinhoOrOne[0]);
                int B = int.Parse(ZerinhoOrOne[1]);
                int C = int.Parse(ZerinhoOrOne[2]);

                if (A == 0 && B == 0 && C == 0 || A == 1 && B == 1 && C == 1) { Console.WriteLine("*"); }

                else if (A == B && B == A) { Console.WriteLine("C"); }

                else if (A == C && C == A) { Console.WriteLine("B"); }

                else
                {
                    Console.WriteLine("A");
                }


            }
        }
    }
}
