using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada;
        while ((entrada = Console.ReadLine()) != null)
        {
            int N = int.Parse(entrada);


            for (int i = 0; i < N; i++)
            {
                string[] Decifrar = Console.ReadLine().Trim().Split(' ');  

                Console.WriteLine((char)(97 + 3 * (Decifrar.Length - 1) + Decifrar[0].Length - 1));
            }
        }

    }

}
