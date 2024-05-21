using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] valores = Console.ReadLine().Split(' ');
            int[] T = new int[n];

            for (int i = 0; i < n; i++)
            {
                T[i] = int.Parse(valores[i]);   

            }

            int menorValor = T[0];
            int indiceMenorValor = 0;
            for (int i = 1; i < n; i++)
            {
                if (T[i] < menorValor)
                {
                    menorValor = T[i];
                    indiceMenorValor = i;
                }
            }
            Console.WriteLine(indiceMenorValor + 1);

        }
    }
}
