using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string format = "0.0000E+00";

            string result = numeroEntrada.ToString(format, CultureInfo.InvariantCulture);
 
            if (result[0] != '-')
            {
                result = "+" + result;  
            }

            Console.WriteLine(result);
        }
    }
}
