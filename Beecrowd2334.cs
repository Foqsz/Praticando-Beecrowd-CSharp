using System; 

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            decimal N = decimal.Parse(Console.ReadLine());

            if (N < 0)
            {
                break;
            }

            decimal patinhos = N - 1;

            if (patinhos < 0)
            {
                patinhos = 0;
            }

            Console.WriteLine(patinhos);
        }


    }
}
