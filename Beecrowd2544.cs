using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int N = int.Parse(entrada.Trim());

            int result = (int)Math.Log(N, 2);

            Console.WriteLine(result); 
        }
    }
}
