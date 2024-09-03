using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
             
            while ((inputLine = Console.ReadLine()) != null)
            { 
                string[] RicardoBarreiroWorld = inputLine.Split(' ');
                int nVisitantes = int.Parse(RicardoBarreiroWorld[0]);
                int alturaMinima = int.Parse(RicardoBarreiroWorld[1]);
                int alturaMaxima = int.Parse(RicardoBarreiroWorld[2]);

                List<int> montanha = new List<int>();
                 
                for (int i = 0; i < nVisitantes; i++)
                {
                    int A = int.Parse(Console.ReadLine());
                    montanha.Add(A);
                }
                 
                int visitantesAptos = montanha.Count(h => h >= alturaMinima && h <= alturaMaxima);
                Console.WriteLine(visitantesAptos);
            }
        }
    }
}
