using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] refrigerante = Console.ReadLine().Split(' ');
            int garrafasVaziasInicioDia = int.Parse(refrigerante[0]);
            int garrafasEncontradasNoDia = int.Parse(refrigerante[1]);
            int garrafasNecessarias = int.Parse(refrigerante[2]);

            int refrigerantesTomados = 0;
            int quantidadeGarrafas = garrafasVaziasInicioDia + garrafasEncontradasNoDia;

            while (quantidadeGarrafas >= garrafasNecessarias)
            { 
                int novosRefrigerantes = quantidadeGarrafas / garrafasNecessarias;
 
                refrigerantesTomados += novosRefrigerantes;
 
                quantidadeGarrafas = quantidadeGarrafas % garrafasNecessarias + novosRefrigerantes;
            }

            Console.WriteLine(refrigerantesTomados);
        }
    }
}
