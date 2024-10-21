using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantAlistados = int.Parse(Console.ReadLine());
            int anoes = 0, elfos = 0, humanos = 0, magos = 0, hobbits = 0;

            for (int i = 0; i < quantAlistados; i++)
            {
                string[] alistado = Console.ReadLine().Split(' ');
                string nome = alistado[0];
                string raca = alistado[1];

                if(raca == "A") { anoes++; }
                else if(raca == "E") { elfos++; }
                else if(raca == "H") { humanos++; }
                else if(raca == "M") { magos++; }
                else { hobbits++; }
            }

            Console.WriteLine($"{hobbits} Hobbit(s)");
            Console.WriteLine($"{humanos} Humano(s)");
            Console.WriteLine($"{elfos} Elfo(s)");
            Console.WriteLine($"{anoes} Anao(oes)");
            Console.WriteLine($"{magos} Mago(s)");
        }  
    }
}
