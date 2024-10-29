using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //duas pernas no chão = portugues
            //levanta esquerda = ingles
            //levanta direita = frances
            //levanta as duas = caiu

            while (true)
            {
                string qualLevantar = Console.ReadLine();

                if (qualLevantar == null) break;

                if(qualLevantar == "esquerda") Console.WriteLine("ingles");
                else if(qualLevantar == "direita") Console.WriteLine("frances");
                else if(qualLevantar == "nenhuma") Console.WriteLine("portugues");
                else Console.WriteLine("caiu");


            }
        }
    }
}
