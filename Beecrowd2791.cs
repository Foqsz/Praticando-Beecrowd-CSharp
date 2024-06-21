using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jogoFeijao = Console.ReadLine().Split(' ');
            int C1 = int.Parse(jogoFeijao[0]);
            int C2 = int.Parse(jogoFeijao[1]);
            int C3 = int.Parse(jogoFeijao[2]);
            int C4 = int.Parse(jogoFeijao[3]);

            string result;

            if (C1 == 1 && C2 == 0 && C3 == 0 && C4 == 0) { result = "1"; }
            else if (C1 == 0 && C2 == 1 && C3 == 0 && C4 == 0) { result = "2"; }
            else if (C1 == 0 && C2 == 0 && C3 == 1 && C4 == 0) { result = "3"; }
            else { result = "4"; }

            Console.WriteLine(result);
             
        }
    }
}
