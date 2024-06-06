using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);

            double porcentagemIngresso;

            porcentagemIngresso = ((B * 100) / A) - 100;  

            Console.WriteLine(porcentagemIngresso.ToString("F2", CultureInfo.InvariantCulture) + "%");
 
        }
    }
}
