using System;
//https://judge.beecrowd.com/pt/runs/code/39534217
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            
            while (Z <= X)
            {
                Z = int.Parse(Console.ReadLine());

                if (Z > X)
                { 
                    break;
                }
            }

            int resultado = 1, soma = X;
            while (soma <= Z)
            {
                soma += X + resultado;
                resultado++;
            }
            Console.WriteLine(resultado);

        }
    }
}
