using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos números
            int A = int.Parse(Console.ReadLine()); // Valor de -10000 até 10000
            int B = int.Parse(Console.ReadLine()); // Valor de 0 até 99
            int C = int.Parse(Console.ReadLine()); // Valor de 0 até 999

            // 1. Saída normal
            Console.WriteLine($"A = {A}, B = {B}, C = {C}");

            // 2. Saída justificada à direita em um espaço de 10 dígitos
            Console.WriteLine($"A = {A,10}, B = {B,10}, C = {C,10}");

            // 3. Saída preenchida com zeros em um espaço de 10 dígitos
            // A solução aqui considera o sinal de números negativos e preenche corretamente com zeros
            Console.WriteLine($"A = {A.ToString("D10")}, B = {B.ToString("D10")}, C = {C.ToString("D10")}");

            // 4. Saída justificada à esquerda em um espaço de 10 dígitos
            Console.WriteLine($"A = {A,-10}, B = {B,-10}, C = {C,-10}");

        }
    }
}
