using System;
using System.Globalization;
//by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);

                ResultadoSoma(x, y);  //Chamando a variavel apos coletar os dados x e y
            }
        }

        static void ResultadoSoma(int x, int y) // variavel retornando void
        {
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double soma = (double)x / y; 
                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
