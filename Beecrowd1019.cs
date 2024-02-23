using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            int seg = int.Parse(Console.ReadLine());
            Console.WriteLine($"{seg / 3600}:{(seg%3600)/60}:{seg%60}");
        }
    }
}
