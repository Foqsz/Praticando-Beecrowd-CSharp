using System; 
//by @Foqsz
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = int.Parse(Console.ReadLine());
            
            for (int i = numero; contador < 6; i++)
            { 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    contador++;
                }
            } 
        }
    }
}

