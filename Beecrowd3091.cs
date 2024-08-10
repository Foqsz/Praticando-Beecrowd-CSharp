using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int Divisao = A % B;

            int saberResto = Math.Abs(Divisao);

            Console.WriteLine(saberResto);
        } 
    }   
}
