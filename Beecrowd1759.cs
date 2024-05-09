using System;

namespace Course
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string Noel = "Ho";
            for (int i = 0; i < N - 1; i++)
            {
                Console.Write(Noel.TrimEnd() + " "); 
            }
            Console.WriteLine(Noel + "!");
        }
    }
}
