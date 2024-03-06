using System;
using System.Globalization; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, perimetro, area;

            string[] valores = Console.ReadLine().Split(' ');
            a = float.Parse(valores[0], CultureInfo.InvariantCulture);
            b = float.Parse(valores[1], CultureInfo.InvariantCulture);
            c = float.Parse(valores[2], CultureInfo.InvariantCulture);

            perimetro = a + b + c; 
            area = ((a + b) * c) / 2;

            if ((a<b+c) && (b<a+c) && (c<a+b))
            { 
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
            Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}"); 
            } 
        }
    }
}

