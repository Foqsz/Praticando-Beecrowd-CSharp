using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            while ((entrada = Console.ReadLine()) != null)
            {
                int n = int.Parse(entrada);

                if (n == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                } 
            }
        }
    }
}
