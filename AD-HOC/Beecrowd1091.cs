using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int casosDeTestes = int.Parse(Console.ReadLine());

                if (casosDeTestes == 0) break;

                string[] coordenadas = Console.ReadLine().Split();
                int N = int.Parse(coordenadas[0]);
                int M = int.Parse(coordenadas[1]);

                for (int i = 0; i < casosDeTestes; i++)
                {
                    string[] residencia = Console.ReadLine().Split();
                    int X = int.Parse(residencia[0]);
                    int Y = int.Parse(residencia[1]);

                    if (X == N || Y == M)
                    {
                        Console.WriteLine("divisa");
                    }
                    else if (X < N && Y > M)
                    {
                        Console.WriteLine("NO");
                    }
                    else if (X > N && Y > M)
                    {
                        Console.WriteLine("NE");
                    }
                    else if (X > N && Y < M)
                    {
                        Console.WriteLine("SE");
                    }
                    else if (X < N && Y < M)
                    {
                        Console.WriteLine("SO");
                    }
                }
            }
        }
    }
}
