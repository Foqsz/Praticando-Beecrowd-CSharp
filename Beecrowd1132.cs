using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
 
            double resultado = 0;

            int menor = Math.Min(x, y);
            int maior = Math.Max(x, y); 

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)  
                {
                    resultado += i;
                }

            }
            Console.WriteLine(resultado);
        }
    }
}
