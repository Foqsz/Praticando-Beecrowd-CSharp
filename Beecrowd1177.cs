using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[1000];
            int entrada = int.Parse(Console.ReadLine());
            int valor = 0;

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = valor;
                valor = (valor + 1) % entrada; // Incrementando valor e volta para 0 quando chegar ao valor de entrada
                Console.WriteLine($"N[{i}] = {vet[i]}");

                if (i == 999) // Reinicia valor quando atingir a última posição do array
                    valor = 0;
            }

            string n = Console.ReadLine();
        }
    }
}
