using System;

class Program
{
    static void Main(string[] args)
    { 
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        { 
            long numero = long.Parse(Console.ReadLine());
            string binario = DecimalParaBinario(numero);
            int maxSequencia = EncontrarMaiorSequenciaConsecutivaDeUns(binario);
            Console.WriteLine(maxSequencia);
        }
    }

    static string DecimalParaBinario(long numeroDecimal)
    {
        if (numeroDecimal == 0) return "0";
        string valor = "";
        while (numeroDecimal > 0)
        {
            valor = (numeroDecimal % 2) + valor;
            numeroDecimal = numeroDecimal / 2;
        }
        return valor;
    }

    static int EncontrarMaiorSequenciaConsecutivaDeUns(string binario)
    {
        int maxSequencia = 0;
        int contador = 0;

        foreach (char c in binario)
        {
            if (c == '1')
            {
                contador++;
                if (contador > maxSequencia)
                {
                    maxSequencia = contador;
                }
            }
            else
            {
                contador = 0;
            }
        }

        return maxSequencia;
    }
}
