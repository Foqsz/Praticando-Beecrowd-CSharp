using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                int Ano = int.Parse(entrada);

                int Seculo = (Ano + 99) / 100;
                Console.WriteLine(Seculo);
            }
        }
    }
}
