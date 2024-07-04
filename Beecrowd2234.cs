using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] hotDog = Console.ReadLine().Split(' ');
        decimal H = decimal.Parse(hotDog[0]);
        decimal P = decimal.Parse(hotDog[1]);

        decimal soma = H / P;
        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}
