using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                string entrada = Console.ReadLine();
                 
                if (entrada == "P=NP")
                {
                    Console.WriteLine("skipped");
                    continue;
                }
                 
                string[] PhD = entrada.Split('+');
                int A = int.Parse(PhD[0]);
                int B = int.Parse(PhD[1]);

                int sum = A + B;
                Console.WriteLine(sum);
            }
        }
    }
}
