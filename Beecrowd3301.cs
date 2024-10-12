using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            { 
                Dictionary<string, int> idades = new Dictionary<string, int>()
                {
                    { "huguinho", int.Parse(entrada.Split(' ')[0]) },
                    { "zezinho", int.Parse(entrada.Split(' ')[1]) },
                    { "luisinho", int.Parse(entrada.Split(' ')[2]) }
                };

                //ordernando e selecionando quem ficou no meio
                string resultado = idades.OrderBy(x => x.Value).ElementAt(1).Key;
 
                Console.WriteLine(resultado);
            }
        }
    }
}
