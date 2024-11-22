using System;  

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                string jogo = Console.ReadLine();

                int n1 = int.Parse(jogo[0].ToString()); 
                int n2 = int.Parse(jogo[2].ToString());

                if (n1 == n2)
                {
                    Console.WriteLine(n1 * n2);
                }

                else if (char.IsUpper(jogo[1]))
                {
                    Console.WriteLine(n2 - n1);
                }

                else
                {
                    Console.WriteLine(n1 + n2);
                }
            }

        }
    }
}
