using System; 

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        char letra = 'a';

        string resultado = new string(letra, N);
        Console.Write($"Feliz nat{resultado}l!");
        Console.WriteLine("");

    }
}

