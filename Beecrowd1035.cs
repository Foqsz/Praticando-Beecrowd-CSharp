using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);
            int c = int.Parse(numeros[2]);
            int d = int.Parse(numeros[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            } 
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}
