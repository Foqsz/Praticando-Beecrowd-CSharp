using System; 
//By @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {  
                if (n == 0 || n < 0)
                {
                    n = 1;
                }
                vet[i] = n * (int)Math.Pow(2, i);
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
