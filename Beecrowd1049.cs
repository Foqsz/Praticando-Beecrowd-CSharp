using System; 
//Obs: Desativar o Console Write iniciais, pois vai dar erro. Colocado apenas para melhor visualização.

// Desenvolved by @foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os tipos");
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();
           Console.Write("Especie: ");
            string especie = Console.ReadLine();
            Console.Write("Alimentacacao: ");
            string alimentacacao = Console.ReadLine();

            if (tipo == "vertebrado")
            {
                if (especie == "ave")
                {
                    if (alimentacacao == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (alimentacacao == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (especie == "mamifero")
                {
                    if (alimentacacao == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (alimentacacao == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if (tipo == "invertebrado")
            {
                if (especie == "inseto")
                {
                    if (alimentacacao == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (alimentacacao == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (especie == "anelideo")
                {
                    if (alimentacacao == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (alimentacacao == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
