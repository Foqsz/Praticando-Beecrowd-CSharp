using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palavra = Console.ReadLine();

                if (string.IsNullOrEmpty(palavra))
                {
                    break;
                }

                else if (palavra.Length >= 10)
                {
                    Console.WriteLine("palavrao");
                }

                else
                {
                    Console.WriteLine("palavrinha");
                }
            }
        }
    }
}
