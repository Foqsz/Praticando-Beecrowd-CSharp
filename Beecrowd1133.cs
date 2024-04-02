using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int x = int.Parse(Console.ReadLine());  
            int y = int.Parse(Console.ReadLine());

            // Garantir que x seja menor que y
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            // Iterar de x até y, verificando o resto da divisão por 5
            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
