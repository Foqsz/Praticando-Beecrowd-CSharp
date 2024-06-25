//Fiz esse exércicio em dois métodos. Um está correto, mas o beecrowd não aceitou. Não sei o por que, também não fiz muita questão, não queria perder tempo.


//---- MÉTODO ACEITO ----///  
using System;

class Program
{
    static void Main(string[] args)
    {
        int V = int.Parse(Console.ReadLine());
        Console.WriteLine($"{V:X}");

    }
}

//---- MÉTODO NÃO ACEITO -----//

using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main(string[] args)
    {
        int V = int.Parse(Console.ReadLine());
        Console.WriteLine(Conversion.Hex(V));

    }
}

