using System; 

class Program
{
    static void Main(string[] args)
    {
        string entrada;
        while ((entrada = Console.ReadLine()) != null)
        {
            int N = int.Parse(entrada);

            if (N < 1000 || N > 9999)
            {
                break;
            }
            Console.WriteLine(N - 1);


        }
    }
}

