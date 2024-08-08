using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            while ((entrada = Console.ReadLine()) != null)
            {
                int casosTeste = int.Parse(entrada);

                List<double> umilBolt = new List<double>();

                for (int i = 0; i < casosTeste; i++)
                {
                    double T = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    umilBolt.Add(T);
                }

                Console.WriteLine(umilBolt.Min().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
