using System;
//Developed by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=1,b=2,c=3, n;
            n = int.Parse(Console.ReadLine());     
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a} {b} {c} PUM");
                a += 4;
                b += 4;
                c += 4;    
            }
        }
    }
}
