using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop infinito para ler pares de números até que X seja igual a Y
            {
                string[] numeros = Console.ReadLine().Split(' '); 
                int x = int.Parse(numeros[0]);  
                int y = int.Parse(numeros[1]); 

                if (x == y) // Verifico se X é igual a Y para encerrar o loop
                    break;

                Console.WriteLine(Ordem(x, y)); // Aqui eu chamo a função para determinar a ordem e imprime o resultado
            }
        }

        static string Ordem(int x, int y)
        {
            if (x > y)  
            {
                return "Decrescente";  
            }
            else if (y > x)  
            {
                return "Crescente";  
            }
            else  
            {
                return "";  
            }
        }
    }
}
