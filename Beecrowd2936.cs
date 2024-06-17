using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] precos = { 300, 1500, 600, 1000, 150 }; 
            int donaChica = 225;  

            int somaTotal = 0;
             
            for (int i = 0; i < 5; i++)
            {
                int quantidade = int.Parse(Console.ReadLine());
                somaTotal += quantidade * precos[i];
            }
              
            somaTotal += donaChica;

            Console.WriteLine(somaTotal);
        }
    }
}
