using System;

namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                string[] timesIda = Console.ReadLine().Split(new[] { ' ', 'x' }, StringSplitOptions.RemoveEmptyEntries);
                int t1Mandante = int.Parse(timesIda[0]);
                int t2Visitante = int.Parse(timesIda[1]);

                string[] timesVolta = Console.ReadLine().Split(new[] { ' ', 'x' }, StringSplitOptions.RemoveEmptyEntries);
                int t2Mandante = int.Parse(timesVolta[0]);
                int t1Visitante = int.Parse(timesVolta[1]);

                int saldoDeGolst1 = (t1Mandante + t1Visitante) - (t2Mandante + t2Visitante);
                int saldoDeGolst2 = -saldoDeGolst1; // Inverso
                int golsNaCasat1 = t1Visitante;  
                int golsNaCasat2 = t2Visitante;

                if (saldoDeGolst1 > saldoDeGolst2)
                {
                    Console.WriteLine("Time 1");
                }
                else if (saldoDeGolst2 > saldoDeGolst1)
                {
                    Console.WriteLine("Time 2");
                }
                else if (golsNaCasat1 > golsNaCasat2)
                {
                    Console.WriteLine("Time 1");
                }
                else if (golsNaCasat2 > golsNaCasat1)
                {
                    Console.WriteLine("Time 2");
                }
                else
                {
                    Console.WriteLine("Penaltis");
                }
            }
        }
    }
}
