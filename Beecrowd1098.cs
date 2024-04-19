using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double red; 
            for (int i = 0; i <= 20; i += 2)
            {
                red = i / 10.0; 
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("I={0} J={1}", red, j + red);
                }

            }
        }
    }
}
