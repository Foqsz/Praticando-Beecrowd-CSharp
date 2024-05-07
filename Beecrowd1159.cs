using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool respostas = true;
            while (respostas)
            {
                int X = int.Parse(Console.ReadLine());

                if (X == 0)
                {
                    respostas = false;
                    break;  
                }

                int soma = 0;
                if (X % 2 != 0)
                {
                    X++;  
                }
                for (int i = 0; i < 5; i++)
                {
                    soma += X + (i * 2);  
                }
                Console.WriteLine(soma);
            }
        }
    }
}
