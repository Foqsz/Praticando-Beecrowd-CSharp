using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontosSobreCircuferencia = int.Parse(Console.ReadLine());

            if (pontosSobreCircuferencia < 1 || pontosSobreCircuferencia > 1000)
            {
                throw new ArgumentException("Número de pontos deve estar entre 1 e 1000.");
            }

            Console.WriteLine(CalcularQuantidadePartesCirculo(pontosSobreCircuferencia));
        }

        static long CalcularQuantidadePartesCirculo(int pontosSobreCircuferencia)
        {
            if (pontosSobreCircuferencia < 1) return 0;

            long comb2 = (long)pontosSobreCircuferencia * (pontosSobreCircuferencia - 1) / 2;
            long comb4 = (long)pontosSobreCircuferencia * (pontosSobreCircuferencia - 1) * (pontosSobreCircuferencia - 2) * (pontosSobreCircuferencia - 3) / 24;

            long quantidadePartesDoCirculo = 1 + comb2 + comb4;

            return quantidadePartesDoCirculo;
        }
    }
}
