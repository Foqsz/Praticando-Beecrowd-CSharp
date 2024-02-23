using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int vel = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double dist = (temp * vel) / 12.00;
            Console.WriteLine(dist.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
