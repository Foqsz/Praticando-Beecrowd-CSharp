using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] results = new string[T];

            for (int i = 0; i < T; i++)
            {
                string[] respostas = Console.ReadLine().Split(' ');
                string r1 = respostas[0];
                string r2 = respostas[1];

                if (r1 == r2)
                {
                    results[i] = $"Caso #{i + 1}: De novo!";
                }
                else if ((r1 == "tesoura" && (r2 == "papel" || r2 == "lagarto")) ||
                         (r1 == "papel" && (r2 == "pedra" || r2 == "Spock")) ||
                         (r1 == "pedra" && (r2 == "lagarto" || r2 == "tesoura")) ||
                         (r1 == "lagarto" && (r2 == "Spock" || r2 == "papel")) ||
                         (r1 == "Spock" && (r2 == "tesoura" || r2 == "pedra")))
                {
                    results[i] = $"Caso #{i + 1}: Bazinga!";
                }
                else
                {
                    results[i] = $"Caso #{i + 1}: Raj trapaceou!";
                }
            }

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
