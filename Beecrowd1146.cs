using System;  
using System.Text;  

namespace Course  
{
    internal class Program  
    {
        static void Main(string[] args)  
        {
            int x;  
            StringBuilder output = new StringBuilder(); // Declara um objeto StringBuilder chamado "output" para construir a saída de forma eficiente.

            while ((x = int.Parse(Console.ReadLine())) != 0) // Enquanto o valor digitado não for zero, continua a execução.
            {
                output.Clear(); // Limpa o conteúdo atual do StringBuilder "output" para uma nova linha.

                for (int i = 1; i <= x; i++)  
                {
                    output.Append(i); // Adiciona o número atual ao StringBuilder "output".

                    if (i < x)  
                    {
                        output.Append(" "); // Adiciona um espaço ao StringBuilder "output" para separar os números.
                    }
                }

                Console.WriteLine(output);  
            }
        }
    }
}
