using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            int result;

            for (int i = 0; i < 20; i++)
            {
                int x = int.Parse(Console.ReadLine());
                vet[i] = x;
            }

            for (int i = 0; i < 10; i++)
            {
                result = vet[i];
                vet[i] = vet[19 - i];
                vet[19 - i] = result;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
