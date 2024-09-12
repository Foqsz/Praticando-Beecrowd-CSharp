using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeElfos = int.Parse(Console.ReadLine());
            int bonecos = 0, arquitetos = 0, musicos = 0, desenhistas = 0;
            int horasBonecos = 0, horasArquitetos = 0, horasMusicos = 0, horasDesenhistas = 0;

            for (int i = 0; i < quantidadeElfos; i++)
            {
                string[] Elfos = Console.ReadLine().Split(' ');
                string Nome = Elfos[0];
                string Grupo = Elfos[1];
                int horasCedidas = int.Parse(Elfos[2]);

                if (Elfos[1] == "bonecos") { bonecos++; horasBonecos += horasCedidas; }
                else if(Elfos[1] == "arquitetos") { arquitetos++; horasArquitetos += horasCedidas; }
                else if (Elfos[1] == "musicos") {  musicos++; horasMusicos += horasCedidas; }
                else { desenhistas++; horasDesenhistas  += horasCedidas; }  
            }

            int somaBonecos = horasBonecos / 8;
            int somaArquitetos = horasArquitetos / 4;
            int somaMusicos = horasMusicos / 6;
            int somaDesenhistas = horasDesenhistas / 12;

            Console.WriteLine(somaBonecos + somaArquitetos + somaMusicos + somaDesenhistas);
        }
    }
}
