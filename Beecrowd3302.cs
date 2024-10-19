using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantPerguntas = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantPerguntas; i++)
            {
                int resposta = int.Parse((Console.ReadLine()));

                Console.WriteLine($"resposta {i + 1}: {resposta}");
            }
        }
    }
}
