using System;
using System.Text.RegularExpressions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int nBatalhas = int.Parse(Console.ReadLine());
            int batalhasVencidas = 0;

            for (int i = 0; i < nBatalhas; i++)
            {
                string habilidadesUsadas = Console.ReadLine();

                string sequenciaHabilidadesProibidas = "CD";

                bool isSequence = Regex.IsMatch(habilidadesUsadas, $"(?<=^|\\d*){Regex.Escape(sequenciaHabilidadesProibidas)}(?=\\d*$)");

                if (isSequence is false)
                {
                    batalhasVencidas++;
                }

            } 
            Console.WriteLine(batalhasVencidas);
        }
    }
}
