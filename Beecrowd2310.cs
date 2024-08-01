using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nJogadores = int.Parse(Console.ReadLine());
            double Saques = 0, Bloqueios = 0, Ataques = 0;
            double SaquesB = 0, BloqueiosB = 0, AtaquesB = 0;
             
            for (int i = 0; i < nJogadores; i++)
            {
                string Nome = Console.ReadLine();
                string[] Tentativas = Console.ReadLine().Split(' ');
                int S = int.Parse(Tentativas[0]);
                int B = int.Parse(Tentativas[1]);
                int C = int.Parse(Tentativas[2]);

                Saques += S;
                Bloqueios += B;
                Ataques += C;

                string[] Sucesso = Console.ReadLine().Split(' ');
                int S1 = int.Parse(Sucesso[0]);
                int B1 = int.Parse(Sucesso[1]);
                int C1 = int.Parse(Sucesso[2]);

                SaquesB += S1;
                BloqueiosB += B1;
                AtaquesB += C1;
            }

            double resultSaques = ((double)SaquesB / Saques) * 100;
            double resultBloqueios = ((double)BloqueiosB / Bloqueios) * 100;
            double resultAtaques = ((double)AtaquesB / Ataques) * 100;

            Console.WriteLine($"Pontos de Saque: {resultSaques.ToString("F2", CultureInfo.InvariantCulture)} %.");
            Console.WriteLine($"Pontos de Bloqueio: {resultBloqueios.ToString("F2", CultureInfo.InvariantCulture)} %.");
            Console.WriteLine($"Pontos de Ataque: {resultAtaques.ToString("F2", CultureInfo.InvariantCulture)} %.");
        }

    } 
}
