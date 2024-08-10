using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosTestes; i++)
            {
                //a arvore deve ter ate 200 cm de altura e nao deve ser maior que 300 cm e os numeros de galhos tem que ser maior ou igual a 150

                string[] arvoreNatal = Console.ReadLine().Split(' ');
                int alturaArvoreCM = int.Parse(arvoreNatal[0]);
                int diametroArvore = int.Parse(arvoreNatal[1]);
                int quantidadeGalhosArvore = int.Parse(arvoreNatal[2]);

                Console.WriteLine(ArvoreDeNatal(alturaArvoreCM, diametroArvore, quantidadeGalhosArvore));
            }
        }

        static string ArvoreDeNatal(int alturaArvore, int diametroArvore, int quantidadeGalhos)
        {
            if (alturaArvore >= 200 && alturaArvore <= 300 && diametroArvore >= 50 && quantidadeGalhos >= 150)
            {
                return "Sim";
            }
            else
            {
                return "Nao";
            }
        }
    }   
}
