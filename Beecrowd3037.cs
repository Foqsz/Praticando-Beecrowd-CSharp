using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPartidas = int.Parse(Console.ReadLine());

            for (int i = 0; i < nPartidas; i++)
            {
                //Player Joao
                string[] PartidaJoao1 = Console.ReadLine().Split(' ');
                int joaoArremessoA = int.Parse(PartidaJoao1[0]);
                int joaoArremessoB = int.Parse(PartidaJoao1[1]);

                string[] PartidaJoao2 = Console.ReadLine().Split(' ');
                int joaoArremessoC = int.Parse(PartidaJoao2[0]);
                int joaoArremessoD = int.Parse(PartidaJoao2[1]);

                string[] PartidaJoao3 = Console.ReadLine().Split(' ');
                int joaoArremessoE = int.Parse(PartidaJoao3[0]);
                int joaoArremessoF = int.Parse(PartidaJoao3[1]);

                //Player Maria
                string[] PartidaMaria1 = Console.ReadLine().Split(' ');
                int mariaArremessoA = int.Parse(PartidaMaria1[0]);
                int mariaArremessoB = int.Parse(PartidaMaria1[1]);

                string[] PartidaMaria2 = Console.ReadLine().Split(' ');
                int mariaArremessoC = int.Parse(PartidaMaria2[0]);
                int mariaArremessoD = int.Parse(PartidaMaria2[1]);

                string[] PartidaMaria3 = Console.ReadLine().Split(' ');
                int mariaArremessoE = int.Parse(PartidaMaria3[0]);
                int mariaArremessoF = int.Parse(PartidaMaria3[1]);

                int somarJoao = (joaoArremessoA * joaoArremessoB) + (joaoArremessoC * joaoArremessoD) + (joaoArremessoE * joaoArremessoF);
                int somarMaria = (mariaArremessoA * mariaArremessoB) + (mariaArremessoC * mariaArremessoD) + (mariaArremessoE * mariaArremessoF);

                if(somarJoao >= somarMaria) { Console.WriteLine("JOAO"); }
                else { Console.WriteLine("MARIA"); }

            } 
        }
    }
}

///Método dois

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPartidas = int.Parse(Console.ReadLine());

            for (int i = 0; i < nPartidas; i++)
            {
                // Player Joao
                int joaoPontuacao = CalcularPontuacao();

                // Player Maria
                int mariaPontuacao = CalcularPontuacao();

                if (joaoPontuacao >= mariaPontuacao)
                {
                    Console.WriteLine("JOAO");
                }
                else
                {
                    Console.WriteLine("MARIA");
                }
            }
        }

        static int CalcularPontuacao()
        {
            int total = 0;

            for (int j = 0; j < 3; j++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int arremessoA = int.Parse(entrada[0]);
                int arremessoB = int.Parse(entrada[1]);
                total += arremessoA * arremessoB;
            }

            return total;
        }
    }
}
