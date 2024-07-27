using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());

                if (s <= 8000)
                {
                    Console.WriteLine("Inseto!");
                }
                else
                {
                    Console.WriteLine("Mais de 8000!");
                }
            }
        }
    }
}
