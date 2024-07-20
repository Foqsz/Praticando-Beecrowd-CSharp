using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int qntJipesNoParque = 0;
        int qntTuristasNoParque = 0;

        while (true)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            string status = entrada[0];
            if (status == "ABEND")
            {
                break;
            }

            int qntTuristas = int.Parse(entrada[1]);

            if (status == "SALIDA")
            {
                qntJipesNoParque++;
                qntTuristasNoParque += qntTuristas;
            }
            else if (status == "VUELTA")
            {
                qntJipesNoParque--;
                qntTuristasNoParque -= qntTuristas;
            }
        } 

        Console.WriteLine(qntTuristasNoParque);
        Console.WriteLine(qntJipesNoParque);
    }
}
