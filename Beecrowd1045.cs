using System;
//Developed by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');
            double a = double.Parse(entradas[0]);
            double b = double.Parse(entradas[1]);
            double c = double.Parse(entradas[2]);
 
            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                double temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                double temp = b;
                b = c;
                c = temp;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
