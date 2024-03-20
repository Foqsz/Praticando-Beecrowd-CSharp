using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double soma = a + b;
            Console.WriteLine("X = " + soma);
        }
    }
}
