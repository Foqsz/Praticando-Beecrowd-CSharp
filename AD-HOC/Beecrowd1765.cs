using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int casosDeTeste = int.Parse(Console.ReadLine());

                double totalSorvete = 0;
                
                if (casosDeTeste == 0) { break; }

                for (int i = 0; i < casosDeTeste; i++)
                {
                   string[] valores = Console.ReadLine().Split(' ');
                   int quantTrapezios = int.Parse(valores[0]);
                   double valorTrapezioA = double.Parse(valores[1], CultureInfo.InvariantCulture);
                   double valorTrapezioB = double.Parse(valores[2], CultureInfo.InvariantCulture);

                   double altura = 5.0;
                   
                   double area = ((valorTrapezioA + valorTrapezioB) * altura) / 2;

                   totalSorvete = quantTrapezios * area;
                   
                   Console.WriteLine($"Size #{i + 1}:");
                   Console.WriteLine($"Ice Cream Used: {totalSorvete.ToString("F2", CultureInfo.InvariantCulture)} cm2");
                }

                Console.WriteLine();
            }
        }
    }
}
