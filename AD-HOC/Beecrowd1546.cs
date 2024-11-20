using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                int quantFeedbacks = int.Parse(Console.ReadLine());

                for (int j = 0; j < quantFeedbacks; j++)
                {
                    int numFeedback = int.Parse(Console.ReadLine());

                    if (numFeedback == 1) { Console.WriteLine("Rolien"); }
                    else if (numFeedback == 2) { Console.WriteLine("Naej"); }
                    else if (numFeedback == 3) { Console.WriteLine("Elehcim"); }
                    else { Console.WriteLine("Odranoel"); }
                }
            }

        }
    }
}
