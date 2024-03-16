using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 60;

            while (j >= 0)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }
        }
    }
}
