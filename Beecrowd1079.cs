using System;  
using System.Globalization;  
// Developed by @Foqsz
namespace Course  
{
    internal class Program  
    {
        static void Main(string[] args) 
        {
            int N = int.Parse(Console.ReadLine());  

            for (int i = 0; i < N; i++)  
            {
                string[] medias = Console.ReadLine().Split(' ');  
                double mediaUm = double.Parse(medias[0], CultureInfo.InvariantCulture);  
                double mediaDois = double.Parse(medias[1], CultureInfo.InvariantCulture);  
                double mediaTres = double.Parse(medias[2], CultureInfo.InvariantCulture);  

                double somaMedias = SomaMedia(mediaUm, mediaDois, mediaTres); // Calcula a soma das médias
                Console.WriteLine(somaMedias.ToString("F1", CultureInfo.InvariantCulture));  
            }
        }

        // Função para calcular a soma das médias
        static double SomaMedia(double mediaUm, double mediaDois, double mediaTres)
        {
            // Calcula a soma das médias
            double somaMedia = ((mediaUm * 2) + (mediaDois * 3) + (mediaTres * 5)) / (2 + 3 + 5);

            return somaMedia;
        }
    }
}
