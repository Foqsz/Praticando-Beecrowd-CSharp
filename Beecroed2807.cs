//Fiz dois códigos para este exércicio. Um, eu apenas adaptei o código que fiz sobre Fibonacci, obtive os mesmos resultados, mas no beecrowd dava erro, não entendi o por que... 

//Código com erro

using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0;
            int b = 1;

            List<int> list = new List<int>();

            n = int.Parse(Console.ReadLine());
             
            for (int i = 1; i < n; i++)
            {  
                int temp = a;
                a = b;
                b = temp + b;
                list.Add(b);
            }

            list.Sort();
            list.Reverse(); 

            string result = string.Join(" ", list);
            Console.Write(result); 
            Console.Write(" 1");
            Console.WriteLine("");
        }
    }
}

//Código sem erro

using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 40)
            {
                throw new ArgumentException("N deve estar entre 1 e 40.");
            }
 
            List<int> sequence = new List<int>();

            // Adicionando os dois últimos termos fixos
            if (n == 1)
            {
                sequence.Add(1);
            }
            else if (n >= 2)
            {
                sequence.Add(1); // Último termo
                sequence.Add(1); // Penúltimo termo

                // Preenchendo os termos restantes da sequência
                for (int i = 2; i < n; i++)
                {
                    // O próximo termo é a soma dos dois últimos termos
                    int nextTerm = sequence[0] + sequence[1];
                    sequence.Insert(0, nextTerm); // Adiciona no início
                }
            }

            // Convertendo a lista para string e imprime
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
