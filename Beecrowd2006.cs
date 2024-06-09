using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 

            int T = int.Parse(Console.ReadLine());
            int acertos = 0;

            string[] tipoCha = Console.ReadLine().Split(' ');
            int A = int.Parse(tipoCha[0]);
            int B = int.Parse(tipoCha[1]);
            int C = int.Parse(tipoCha[2]);
            int D = int.Parse(tipoCha[3]);
            int E = int.Parse(tipoCha[4]); 

            if (A == T) acertos++;
            if(B == T) acertos++;
            if (C == T) acertos++;
            if (D == T) acertos++;
            if (E == T) acertos++;

            Console.WriteLine(acertos);


        }
    }
}
