using System;
using System.Diagnostics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "AMO FAZER EXERCICIO NO URI";

            Console.WriteLine($"<{uri}>");
            Console.WriteLine($"<{uri,30}>");
            Console.WriteLine($"<{uri.Substring(0, 20)}>");
            Console.WriteLine($"<{uri,-20}>");
            Console.WriteLine($"<{uri,-30}>");
            Console.WriteLine($"<{uri}>");
            Console.WriteLine($"<{uri.Substring(0, 20),30}>");
            Console.WriteLine($"<{uri.Substring(0, 20),-30}>");
        }
    }
}
