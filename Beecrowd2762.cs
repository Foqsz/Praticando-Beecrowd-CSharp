using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S6 = Console.ReadLine().Split('.');
            int A = int.Parse(S6[0]);
            int B = int.Parse(S6[1]);

            Console.WriteLine($"{B}.{A}");


        }

    }
}
