using System;

class Program
{
    static void Main(string[] args)
    {
        string T = Console.ReadLine();

        if (T.Length <= 140)
        {
            Console.WriteLine("TWEET");
        }
        else
        {
            Console.WriteLine("MUTE");
        }
    }
}

