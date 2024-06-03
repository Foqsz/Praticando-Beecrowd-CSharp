using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nTriangulo = Console.ReadLine().Split(' ');
            int A = int.Parse(nTriangulo[0]);
            int B = int.Parse(nTriangulo[1]);
            int C = int.Parse(nTriangulo[2]);
            int D = int.Parse(nTriangulo[3]);
             
            if (IsTriangle(A, B, C) || IsTriangle(A, B, D) || IsTriangle(A, C, D) || IsTriangle(B, C, D))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

        static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
