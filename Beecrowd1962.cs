using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int resultado = SomaTempo(n);

                if (resultado <= 0)
                { 
                    Console.WriteLine($"{Math.Abs(resultado + -1)} D.C.");
                }  

                else
                { 
                    Console.WriteLine($"{resultado} A.C.");
                }
            }
        }

        static int SomaTempo(int n)
        {
            int somaTempo = n - 2015 + 1;
              
            return somaTempo;
        }
    }
}
