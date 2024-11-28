using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int casosDeTeste = int.Parse(Console.ReadLine());
                int mary = 0, john = 0;

                if (casosDeTeste == 0) { break; }

                string[] CaraOuCoroa = Console.ReadLine().Split(' ');
                for (int i = 0; i < casosDeTeste; i++)
                { 
                    int N = int.Parse(CaraOuCoroa[i]);

                    if(N == 0) { mary++;  }
                    else { john++; }
                }
                Console.WriteLine($"Mary won {mary} times and John won {john} times");
            }
        }
    }
}

