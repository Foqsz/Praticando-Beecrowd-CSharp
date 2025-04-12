using System; 

namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        { 
            int contagemP1 = 0;
            int contagemP2 = 0;

            while (true)
            {
                int numEntradas = int.Parse(Console.ReadLine());

                if (numEntradas == 0) break;

                for (int i = 0; i < numEntradas; i++)
                {
                    string[] valores = Console.ReadLine().Split(' ');

                    int p1 = int.Parse(valores[0]);
                    int p2 = int.Parse(valores[1]);

                    if (p1 > p2)
                    {
                        contagemP1++;
                    }
                    else if (p2 > p1)
                    {
                        contagemP2++;
                    }
                }
                Console.WriteLine($"{contagemP1} {contagemP2}"); 
                contagemP1 = 0;
                contagemP2 = 0;
            }
        }
    }
}
