using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int A = int.Parse(entrada[0]);
        int B = int.Parse(entrada[1]);

        int saberQ = A / B;
        int saberR = A % B;

        // Ajuste para garantir que o resto seja não negativo
        if (saberR < 0)
        {
            saberR += Math.Abs(B); // Adiciona o valor absoluto de B ao resto
            saberQ = (A - saberR) / B; // Recalcula o quociente, caso necessário
        }

        Console.WriteLine($"{saberQ} {saberR}");
    }
}
