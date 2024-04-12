using System; 
//Desenvolved by @Foqsz
namespace Course
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrada; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (N == 0)
                {
                    Console.WriteLine("NULL");
                }

                else if (N < 0 && N % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }

                else if (N > 0 && N % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }

                else if (N > 0 && N % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }

                else if (N < 0 && N % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }

        }
    }
} 

