using System;
using System.Globalization;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string cpfInput = input.Replace(".", "").Replace("-", "");

        string[] CPF = new string[4];
        CPF[0] = cpfInput.Substring(0, 3);
        CPF[1] = cpfInput.Substring(3, 3);
        CPF[2] = cpfInput.Substring(6, 3);
        CPF[3] = cpfInput.Substring(9, 2);
        
        foreach (string x in CPF)
        {
            Console.WriteLine(x);
        } 
    }
     
}
