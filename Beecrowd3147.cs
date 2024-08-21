using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Batalha = Console.ReadLine().Split(' ');
            int eHumanos = int.Parse(Batalha[0]);   
            int eElfos = int.Parse(Batalha[1]);
            int eAnoes = int.Parse(Batalha[2]);
            int eOrcs = int.Parse(Batalha[3]);
            int eWargs = int.Parse(Batalha[4]);
            int eAguias = int.Parse(Batalha[5]);

            //lado bem = humanos, elfos e anões
            //lado mal = orgs, wargs 
            int somaExercicoBem = eHumanos + eElfos + eAnoes;
            int somaExercitoMal = eOrcs + eWargs;

            if (somaExercitoMal >= somaExercicoBem)
            {
                somaExercicoBem += eAguias;
            }

            if (somaExercicoBem > somaExercitoMal) { Console.WriteLine("Middle-earth is safe."); }
            else { Console.WriteLine("Sauron has returned."); }
        }
    }
}
