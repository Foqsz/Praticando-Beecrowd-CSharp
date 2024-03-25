using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este loop externo controla a variável 'i' que começa em 1 e incrementa de 2 em 2 até chegar em 9.
            for (int i = 1; i <= 9; i += 2)
            {
                // Este loop interno controla a variável 'j' que começa em 7 e decrementa até chegar em 5.
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
            }

        }
    }
}
