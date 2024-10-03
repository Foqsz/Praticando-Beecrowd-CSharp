using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elevador = Console.ReadLine().Split(' ');
            int andares = int.Parse(elevador[0]);
            int inicio = int.Parse(elevador[1]);
            int meta = int.Parse(elevador[2]);
            int cima = int.Parse(elevador[3]);
            int baixo = int.Parse(elevador[4]);

            // Se o andar de início já é o andar desejado
            if (inicio == meta)
            {
                Console.WriteLine(0);
                return;
            }

            // Usamos uma fila para BFS e um array para rastrear andares visitados
            Queue<int> fila = new Queue<int>();
            bool[] visitado = new bool[andares + 1];
            int[] dist = new int[andares + 1]; // Para rastrear o número de pressionamentos

            fila.Enqueue(inicio);
            visitado[inicio] = true;
            dist[inicio] = 0;

            while (fila.Count > 0)
            {
                int andarAtual = fila.Dequeue();

                // Calcule o próximo andar ao pressionar UP
                int proximoCima = andarAtual + cima;
                if (proximoCima <= andares && !visitado[proximoCima])
                {
                    fila.Enqueue(proximoCima);
                    visitado[proximoCima] = true;
                    dist[proximoCima] = dist[andarAtual] + 1;

                    // Se alcançamos o andar meta, podemos retornar o resultado
                    if (proximoCima == meta)
                    {
                        Console.WriteLine(dist[proximoCima]);
                        return;
                    }
                }

                // Calcule o próximo andar ao pressionar DOWN
                int proximoBaixo = andarAtual - baixo;
                if (proximoBaixo >= 1 && !visitado[proximoBaixo])
                {
                    fila.Enqueue(proximoBaixo);
                    visitado[proximoBaixo] = true;
                    dist[proximoBaixo] = dist[andarAtual] + 1;

                    // Se alcançamos o andar meta, podemos retornar o resultado
                    if (proximoBaixo == meta)
                    {
                        Console.WriteLine(dist[proximoBaixo]);
                        return;
                    }
                }
            }

            // Se não conseguimos chegar ao andar meta, usamos as escadas
            Console.WriteLine("use the stairs");
        }
    }
}
