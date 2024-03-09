using System; 
//by @Foqsz
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorPares = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    contadorPares++;
                }
            }
            Console.WriteLine(contadorPares + " valores pares");
        }
    }
}

