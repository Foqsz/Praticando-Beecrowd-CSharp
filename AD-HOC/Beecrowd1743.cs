using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tomadaVerificacao = Console.ReadLine().Split(' ');
            string[] plugueVerificacao = Console.ReadLine().Split(' ');
 
            bool checkMaquina = tomadaVerificacao
                .Zip(plugueVerificacao, (n1, n2) => int.Parse(n1) + int.Parse(n2) == 1) // Soma deve ser 1 (1+0 ou 0+1)
                .All(compativel => compativel);

            if (checkMaquina)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}B
