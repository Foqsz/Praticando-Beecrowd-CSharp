using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++)
            {
                string[] mjolnir = Console.ReadLine().Split(' ');
                string nome = mjolnir[0];
                int forca = int.Parse(mjolnir[1]);

                if (nome == "Thor")
                {
                    Console.WriteLine("Y");
                }
                else
                {
                    Console.WriteLine("N");
                }

            }
        }
    }
}
