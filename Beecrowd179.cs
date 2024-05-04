using System;
//By @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetPar = new int[5]; 
            int[] vetImpar = new int[5];  
            int quantEntrada = 0;  
            int quantPar = 0;  
            int quantImpar = 0;  
             
            while (quantEntrada < 15)
            {
                int valor = int.Parse(Console.ReadLine());  

                // Verifica se o número é par
                if (Math.Abs(valor) % 2 == 0)
                {
                    // Se ainda há espaço no array de números pares, adiciona o número ao array
                    if (quantPar < 5)
                    {
                        vetPar[quantPar] = valor; // Adiciona o número ao array de pares
                        quantPar++; // Incrementa a quantidade de pares
                    }

                    // Se o array de números pares está cheio, imprime seus elementos e reinicia o array
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"par[{i}] = " + vetPar[i]); // Imprime os números pares
                        }
                        quantPar = 0; // Reinicia a quantidade de pares
                        vetPar = new int[5]; // Cria um novo array para números pares
                        vetPar[quantPar] = valor; // Adiciona o número ao array de pares
                        quantPar++; // Incrementa a quantidade de pares
                    }
                }

                // Se o número é ímpar (Mesmo procedimento de par, acima)
                else
                {
                     
                    if (quantImpar < 5)
                    {
                        vetImpar[quantImpar] = valor;  
                        quantImpar++;  
                    }
                     
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"impar[{i}] = " + vetImpar[i]);  
                        }
                        quantImpar = 0;  
                        vetImpar = new int[5];  
                        vetImpar[quantImpar] = valor;  
                        quantImpar++; 
                    }
                }
                quantEntrada++; 
            }

            // Imprime os números ímpares que sobraram no array
            for (int i = 0; i < quantImpar; i++)
            {
                Console.WriteLine($"impar[{i}] = " + vetImpar[i]);
            }

            // Imprime os números pares que sobraram no array
            for (int i = 0; i < quantPar; i++)
            {
                Console.WriteLine($"par[{i}] = " + vetPar[i]);
            }
        }
    }
}
