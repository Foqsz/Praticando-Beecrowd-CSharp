using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                int M = int.Parse(entrada);
                Console.WriteLine(CalcularIRA(M).ToString("F4", CultureInfo.InvariantCulture));
            }
        }

        static double CalcularIRA(int M)
        {
            double notaDisciplina = 0;
            double cargaHoraria = 0;

            for (int i = 0; i < M; i++)
            {
                string[] IRA = Console.ReadLine().Split(' ');
                int N = int.Parse(IRA[0]);
                int C = int.Parse(IRA[1]);

                notaDisciplina += N * C;
                cargaHoraria += C;
            }

            return (notaDisciplina / cargaHoraria) / 100;
        }
    }
}
