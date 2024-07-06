using System; 

class Program
{
    static void Main(string[] args)
    {
        string[] viagem = Console.ReadLine().Split(' ');
        int a = int.Parse(viagem[0]);
        int b = int.Parse(viagem[1]);
        int c = int.Parse(viagem[2]);

        int ano = 2016;

        if ((a - b == 0) || (a - c == 0) || (b - c == 0))
        {
            Console.WriteLine("S");
        }
        else
        {
            if ((a + b - c == 0) || (b - a + c == 0) || (c - a + b == 0))
            {
                Console.WriteLine("S");
            }
            else if ((a - b - c == 0) || (b - a - c == 0) || (c - a - b == 0))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
