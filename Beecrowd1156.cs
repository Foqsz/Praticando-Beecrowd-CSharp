using System;
using System.Globalization; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 1, i = 3, j = 2;
            
            while (i <= 39)
            {
                S += i / j;
                i+=2;
                j*=2;
                 
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
