using System;
//By @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] conjunto = Console.ReadLine().Split(' ');
                int x = int.Parse(conjunto[0]);
                int y = int.Parse(conjunto[1]);

                if (x <= 0 || y <= 0)
                {
                    break;
                }

                int menor = Math.Min(x, y);
                int maior = Math.Max(x, y);
                int soma = 0;

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);
            }
        }
    }
}
