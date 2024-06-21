using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] jogoExtremo = Console.ReadLine().Split(' ');
                int X = int.Parse(jogoExtremo[0]);
                int M = int.Parse(jogoExtremo[1]);

                int xpReceber;

                if (X == 0 && M == 0)
                {
                    break;
                }

                xpReceber = X * M;
                Console.WriteLine(xpReceber);
            }

        }
    }
}
