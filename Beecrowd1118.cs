using System;
using System.Globalization;
//I tried my way, but unfortunately I had difficulties. So when I finally solved it, I added comments to the codes to learn and never forget. Att, @Foqsz.
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaUm, mediaDois, novoCalculo = 1;

            do
            {
                do
                { 
                    mediaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                     
                    if (mediaUm < 0.0f || mediaUm > 10.0f)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (mediaUm < 0.0f || mediaUm > 10.0f); // Repete o loop se a nota for inválida.

                do
                { 
                    mediaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                     
                    if (mediaDois < 0.0f || mediaDois > 10.0f)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (mediaDois < 0.0f || mediaDois > 10.0f); // Repete o loop se a nota for inválida.
                 
                Console.WriteLine("media = {0:0.00}", (mediaUm + mediaDois) / 2);

                do
                { 
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());

                } while (novoCalculo != 1 && novoCalculo != 2); // Repete o loop até que o usuário forneça uma entrada válida (1 ou 2).

            } while (novoCalculo == 1); // Repete todo o processo se o usuário escolher fazer um novo cálculo.
        }
    }
}
