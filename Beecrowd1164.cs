using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < x; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool resultado = NumeroPerfeito(n); 
                if (resultado)
                {
                    Console.WriteLine($"{n} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{n} nao eh perfeito");
                }
            }
        }

        static bool NumeroPerfeito(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}
