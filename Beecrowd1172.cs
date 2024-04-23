using System; 
//By @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0 || n < 0)
                {
                    n = 1;
                }

                Console.WriteLine($"X[{i}] = {n}");
            }
        }
    }
}
