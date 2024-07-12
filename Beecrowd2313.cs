using System;  
using System.Linq;

class Program
{
    static void Main(string[] args)
    {  
        string[] entradas = Console.ReadLine().Split(' ');
        int A = int.Parse(entradas[0]);
        int B = int.Parse(entradas[1]);
        int C = int.Parse(entradas[2]); 

        if (A + B <= C || A + C <= B || B + C <= A)
        {
            Console.WriteLine("Invalido");
        }

        else if ((A == B) && (B == C))
        {
            Console.WriteLine("Valido-Equilatero");
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) ||
                Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
                Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2))
            {
                Console.WriteLine("Retangulo: S");
            }
            else
            {
                Console.WriteLine("Retangulo: N");
            }
        }

        else if ((A != B) && (A != C) && (B != C))
        {
            Console.WriteLine("Valido-Escaleno");
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) ||
                Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
                Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2))
            {
                Console.WriteLine("Retangulo: S");
            }
            else
            {
                Console.WriteLine("Retangulo: N");
            }

        }

        else
        {
            Console.WriteLine("Valido-Isoceles");
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) ||
                Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
                Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2))
            {
                Console.WriteLine("Retangulo: S");
            }
            else
            {
                Console.WriteLine("Retangulo: N");
            } 
        }

    }
}

