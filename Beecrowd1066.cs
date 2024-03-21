using System; 
//Feito por @Foqsz
namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroNegativo = 0;
            int numeroPar = 0;
            int numeroPositivo = 0;
            int numeroImpar = 0;

            for (int i = 1; i <= 5; i++)
            {
                int numeros = int.Parse(Console.ReadLine());

                if (numeros % 2 == 0) // Verificando se um numero é par.
                {
                    numeroPar++;
                }
                if (numeros % 2 != 0) // Verificando se um numero é impar.
                {
                    numeroImpar++;
                }
                if (numeros < 0) // Verificando se um numero é negativo.
                {
                    numeroNegativo++;
                }
                if (numeros > 0) // Verificando se um numero é positivo.
                {
                    numeroPositivo++;
                }  
            }
            Console.WriteLine($"{numeroPar} valor(es) par(es)");
            Console.WriteLine($"{numeroImpar} valor(es) impar(es)");
            Console.WriteLine($"{numeroPositivo} valor(es) positivo(s)");
            Console.WriteLine($"{numeroNegativo} valor(es) negativo(s)");
        }
    }
}
