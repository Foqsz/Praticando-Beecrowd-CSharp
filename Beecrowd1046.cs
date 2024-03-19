using System;
//Developed by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');
            double inicio = double.Parse(entradas[0]);
            double fim = double.Parse(entradas[1]);
              
            if (inicio >= fim)
            {
                double soma = fim - inicio + 24.00;
                Console.WriteLine($"O JOGO DUROU {soma} HORA(S)");
            }
            else
            {

                double soma2 = fim - inicio;
                Console.WriteLine($"O JOGO DUROU {soma2} HORA(S)");
            }
 
        }
    }
}
