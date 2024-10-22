using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            string sequenciaProibida = "13";

            bool isInSequence = Regex.IsMatch(n, $"(?<=^|\\d*){Regex.Escape(sequenciaProibida)}(?=\\d*$)");

            if (isInSequence)
            {
                Console.WriteLine($"{n} es de Mala Suerte");
            }
            else
            {
                Console.WriteLine($"{n} NO es de Mala Suerte");
            }


        }
    }
}
