using System;

class Program
{
    static void Main(string[] args)
    {
        int E = int.Parse(Console.ReadLine());

        for (int i = 0; i < E; i++)
        {
            string[] horario = Console.ReadLine().Split(' ');
            int H = int.Parse(horario[0]);
            int M = int.Parse(horario[1]);
            int O = int.Parse(horario[2]);

            if (O == 1)
            {
                Console.WriteLine($"{H.ToString("D2")}:{M.ToString("D2")} - A porta abriu!");
            }
            else
            {
                Console.WriteLine($"{H.ToString("D2")}:{M.ToString("D2")} - A porta fechou!");
            }
        }
    }
}

