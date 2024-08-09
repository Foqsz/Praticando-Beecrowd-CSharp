using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeMonica = int.Parse(Console.ReadLine());
            int idadeFilhoUm = int.Parse(Console.ReadLine());
            int idadeFilhoDois = int.Parse(Console.ReadLine());

            int idadeFilhoTres = idadeMonica - (idadeFilhoUm + idadeFilhoDois);

            int idadeMaisVelha = Math.Max(Math.Max(idadeFilhoUm, idadeFilhoDois), idadeFilhoTres);

            Console.WriteLine(idadeMaisVelha);
        }
    }
}
