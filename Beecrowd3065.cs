using System;
using System.Collections.Generic;
using System.Data;  
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                int nOperadores = int.Parse(Console.ReadLine());
                if (nOperadores == 0) { break; }

                string nCalcular = Console.ReadLine(); 
                i++;

                var resultCalcular = new DataTable().Compute(nCalcular, null); 

                double resultFinale = Convert.ToDouble(resultCalcular);

                if(resultFinale < 0 && nOperadores == 1) { resultFinale =0; }   

                Console.WriteLine($"Teste {i}");
                Console.WriteLine(resultFinale);
                Console.WriteLine();
            }
        }
    }
}
