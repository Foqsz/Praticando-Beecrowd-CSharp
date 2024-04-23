using System; 

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 0;
            int b = 1; 

            n = int.Parse(Console.ReadLine());
            Console.Write(a);
            for (int i = 1; i < n; i++)
            {
                Console.Write(" " + b);

                int temp = a;
                a = b;
                b = temp + b; 
            }
            Console.WriteLine();
        }
    }
}
