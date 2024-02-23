using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);  
            int c = int.Parse(valores[2]);

            int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            int OMaior = (MaiorAB + c +  Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine($"{OMaior} eh o maior");

        }
    }
}
