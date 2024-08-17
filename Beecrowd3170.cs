using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeBolinhas = int.Parse(Console.ReadLine());
            int bolinhasArvoreNatal = int.Parse(Console.ReadLine());

            int bolinhasTotais = bolinhasArvoreNatal / 2;
            int bolinhasFaltando = bolinhasTotais - quantidadeBolinhas;

            if(bolinhasTotais == quantidadeBolinhas || bolinhasFaltando < 0) { Console.WriteLine("Amelia tem todas bolinhas!"); } 
            else { Console.WriteLine($"Faltam {bolinhasFaltando} bolinha(s)"); }
        }
    }
}
