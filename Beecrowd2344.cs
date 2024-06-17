using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result;

            if (n == 0) { result = "E"; }
            else if(n >= 1 && n <= 35) { result = "D"; }
            else if(n >= 36 && n <= 60) { result = "C"; }
            else if(n >= 61 && n <= 85) { result = "B"; }
            else { result = "A"; }

            Console.WriteLine(result);
        } 
    }
}
