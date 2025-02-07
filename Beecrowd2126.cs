using System;
using System.Text;

class Program
{
    static void Main()
    {
        int caso = 1;
        string N1, N2;

        while ((N1 = Console.ReadLine()) != null)
        {
            N2 = Console.ReadLine();
            int count = 0;
            int lastPos = -1;

            for (int i = 0; i <= N2.Length - N1.Length; i++)
            {
                if (N2.Substring(i, N1.Length) == N1)
                {
                    count++;
                    lastPos = i + 1; 
                }
            }

            Console.WriteLine($"Caso #{caso}:");
            if (count > 0)
            {
                Console.WriteLine($"Qtd.Subsequencias: {count}");
                Console.WriteLine($"Pos: {lastPos}");
            }
            else
            {
                Console.WriteLine("Nao existe subsequencia");
            }
            Console.WriteLine();
            caso++;
        }
    }
}
