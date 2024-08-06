using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int gastosGov = 0, gastosEstudantes = 0;

            for (int i = 0; i < N; i++)
            {
                string[] Governo = Console.ReadLine().Split(' ');
                string T = Governo[0];
                int C = int.Parse(Governo[1]);

                if (T == "G") { gastosEstudantes += C; }
                else {  gastosGov += C; }
            }

            if (gastosEstudantes > gastosGov) { Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!"); }
            else { Console.WriteLine("A greve vai parar."); }

        }
    }
}
