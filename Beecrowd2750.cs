using System;

namespace Course
{
    class Program
    {
        static void ImprimirLinhaHorizontal()
        {
            Console.WriteLine(new string('-', 39));
        }

        static void ImprimirCabecalho()
        {
            ImprimirLinhaHorizontal();
            Console.WriteLine("|  decimal  |  octal  |  Hexadecimal  |");
            ImprimirLinhaHorizontal();
        }

        static void ImprimirLinha(int valor)
        {
            Console.Write("|");

            // Imprimir valor decimal
            string valorDecimal = valor.ToString();
            int espacosDecimal = 7 - valorDecimal.Length;
            for (int i = 0; i < espacosDecimal; ++i)
            {
                Console.Write(" ");
            }
            Console.Write($"{valorDecimal}  |");

            // Imprimir valor octal
            string valorOctal = Convert.ToString(valor, 8);
            int espacosOctal = 5 - valorOctal.Length;
            for (int i = 0; i < espacosOctal; ++i)
            {
                Console.Write(" ");
            }
            Console.Write($"{valorOctal}    |");

            // Imprimir valor hexadecimal
            string valorHexadecimal = Convert.ToString(valor, 16).ToUpper();
            int espacosHexadecimal = 4 - valorHexadecimal.Length;
            for (int i = 0; i < espacosHexadecimal; ++i)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"   {valorHexadecimal}          |");
        }

        static void Main(string[] args)
        {
            ImprimirCabecalho();
            for (int i = 0; i < 16; ++i)
            {
                ImprimirLinha(i);
            }
            ImprimirLinhaHorizontal();
        }
    }
}
