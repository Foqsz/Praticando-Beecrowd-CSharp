using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] input = Console.ReadLine().Split(' ');
            List<int> renas = input.Select(int.Parse).ToList();
             
            int totalBolas = renas.Sum();
             
            string[] nomes = { "Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen", "Rudolph" };
             
            int vencedorIndex = (totalBolas - 1) % 9;
             
            Console.WriteLine(nomes[vencedorIndex]);
        }
    }
}
