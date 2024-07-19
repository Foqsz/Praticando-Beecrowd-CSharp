using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string entrada;
        HashSet<string> joiasDistintas = new HashSet<string>();

        while ((entrada = Console.ReadLine()) != null)
        {
            string joia = entrada.Trim();
            joiasDistintas.Add(joia);
        } 

        Console.WriteLine(joiasDistintas.Count);
    }
}
