using System;
using System.Collections.Generic;
using System.Linq; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                string palavra = Console.ReadLine();

                list.Add(palavra);
            }
            Console.WriteLine(list[2]);
            Console.WriteLine(list[6]);
            Console.WriteLine(list[8]); 
        }
    }
}

