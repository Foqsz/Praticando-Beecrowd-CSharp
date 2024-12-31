using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //minimo LA[0], maximo LA[1]
            //minimo LB[0], maximo LB[1]

            int N = int.Parse(Console.ReadLine());

            string[] lavadora = Console.ReadLine().Split(' ');
            int LA = int.Parse(lavadora[0]);
            int LB = int.Parse(lavadora[1]);

            string[] secadora = Console.ReadLine().Split(' ');
            int SA = int.Parse(secadora[0]);
            int SB = int.Parse(secadora[1]);

            if ((N >= LA && N <= LB) && (N >= SA && N <= SB))
                Console.WriteLine("possivel");
            else
                Console.WriteLine("impossivel");
        }
    }
}
