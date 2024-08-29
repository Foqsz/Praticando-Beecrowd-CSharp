using System; 
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                int casosTeste = int.Parse(entrada);

                for (int i = 0; i < casosTeste; i++)
                {
                    string[] Digitos = Console.ReadLine().Split(' ');
                    int N = int.Parse(Digitos[0]);
                    int M = int.Parse(Digitos[1]);

                    Console.WriteLine(CalcularPotencia(N, M));
                }
            }

            static double CalcularPotencia(int N, int M)
            {
                BigInteger resultPotencia = BigInteger.Pow(N, M);
                string resultDigitos = resultPotencia.ToString();
                int quantidadeDigitosPotencia = resultDigitos.Length;

                return quantidadeDigitosPotencia;
            }
        }
    }
}
