using Course.Entities.Enums;
using System;  

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int atkAereo, papel, tesoura; 

        for (int i = 0; i < n; i++)
        {
            string jogadorUm = Console.ReadLine();
            string jogadorDois = Console.ReadLine();

            if (jogadorUm == "ataque" && jogadorDois == "pedra") 
            {
                Console.WriteLine("Jogador 1 venceu");

            }
            else if (jogadorDois == "ataque" && jogadorUm == "pedra")
            {
                Console.WriteLine("Jogador 2 venceu");
            }

            if (jogadorUm == "pedra" && jogadorDois == "papel")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (jogadorDois == "pedra" && jogadorUm == "papel")
            {
                Console.WriteLine("Jogador 2 venceu");
            }

            if (jogadorUm == "ataque" && jogadorDois == "papel")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (jogadorDois == "ataque" && jogadorUm == "papel")
            {
                Console.WriteLine("Jogador 2 venceu");
            }

            if (jogadorUm == "papel" && jogadorDois == "papel")
            {
                Console.WriteLine("Ambos venceram");
            }
            else if (jogadorDois == "papel" && jogadorUm == "papel")
            {
                Console.WriteLine("Ambos venceram");
            }

            if (jogadorUm == "pedra" && jogadorDois == "pedra" || jogadorDois == "pedra" && jogadorUm == "pedra")
            {
                Console.WriteLine("Sem ganhador");
            }

            if (jogadorUm == "ataque" && jogadorDois == "ataque" || jogadorDois == "ataque" && jogadorUm == "ataque")
            {
                Console.WriteLine("Aniquilacao mutua");
            }
        }

    }
}
