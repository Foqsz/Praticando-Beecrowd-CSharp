using System;
using System.Globalization;
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tccNatal = Console.ReadLine().Split(' ');
            int diaEntregaTCC = int.Parse(tccNatal[0]);
            int dataVerificacao = int.Parse(tccNatal[1]);


            if (diaEntregaTCC > dataVerificacao)
            {
                Console.WriteLine("Eu odeio a professora!");
                return;
            }
            if ((dataVerificacao - diaEntregaTCC) >= 3)
            {
                Console.WriteLine("Muito bem! Apresenta antes do Natal!");
            }
            else
            {
                Console.WriteLine("Parece o trabalho do meu filho!");
                if ((diaEntregaTCC + 2) < 24)
                {
                    Console.WriteLine("TCC Apresentado!");
                }
                else
                {
                    Console.WriteLine("Fail! Entao eh nataaaaal!");
                }
            }
        }
    }
}
