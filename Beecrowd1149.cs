using System;
//https://judge.beecrowd.com/pt/problems/view/1149
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');
            int A = int.Parse(entradas[0]);
            int B = int.Parse(entradas[1]);
            int soma = 0; 
            int repeatB = 1; 

            while (B <= 0)
            {
                repeatB++;
                B = int.Parse(entradas[repeatB]); 
            }

            for (int i = 0; i <= B - 1; i++)
            {
                soma = soma + (A + i);
            }
            Console.WriteLine(soma);
        }
    }
}
