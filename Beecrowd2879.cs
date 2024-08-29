using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int nJogos = int.Parse(Console.ReadLine());

            int carrosGanhos = 0;
            for (int i = 0; i < nJogos; i++)
            {
                int portaCarro = int.Parse(Console.ReadLine());

                if (portaCarro != 1)
                {
                    carrosGanhos++;
                }
            }
            Console.WriteLine(carrosGanhos);
        }  
    }
}
