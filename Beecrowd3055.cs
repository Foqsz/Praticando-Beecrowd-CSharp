using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaUm = int.Parse(Console.ReadLine());
            int media = int.Parse(Console.ReadLine());

            int descobrirNotaDois; 

            descobrirNotaDois = (2 * media) - notaUm;

            Console.WriteLine(descobrirNotaDois);
        }
    }
}
