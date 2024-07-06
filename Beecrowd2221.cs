///---- FIZ DUAS VERSÕES, AMBAS APROVADAS ----///

//---- VERSÃO MENOS TRABALHADA ----////

using System; 

class Program
{
    static void Main(string[] args)
    {
        int qntDuelos = int.Parse(Console.ReadLine());

        for (int i = 0; i < qntDuelos; i++)
        {
            int intValorBonus = int.Parse(Console.ReadLine());

            string[] pokeDabriel = Console.ReadLine().Split(' ');
            int valorAtaqueD = int.Parse(pokeDabriel[0]);
            int valorDefesaD = int.Parse(pokeDabriel[1]);
            int levelTreinadorD = int.Parse(pokeDabriel[2]);

            string[] pokeGuarte = Console.ReadLine().Split(' ');
            int valorAtaqueG = int.Parse(pokeGuarte[0]);
            int valorDefesaG = int.Parse(pokeGuarte[1]);
            int levelTreinadorG = int.Parse(pokeGuarte[2]);

            int valorGolpeD = (valorAtaqueD + valorDefesaD) / 2 + intValorBonus;
            int valorGolpeG = (valorAtaqueG + valorDefesaG) / 2 + intValorBonus;

            if (levelTreinadorD % 2 == 0)
            {
                valorGolpeD += intValorBonus;
            }
            
            if (levelTreinadorG % 2 == 0)
            {
                valorGolpeG += intValorBonus;
            }

            if (valorGolpeD > valorGolpeG)
            {
                Console.WriteLine("Dabriel");
            }
            else if (valorGolpeG > valorGolpeD)
            {
                Console.WriteLine("Guarte");
            }
            else
            {
                Console.WriteLine("Empate");
            }
        }

    }
}

////---- VERSÃO COM BOA PRÁTICA-----/////

using System;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeDuelos = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeDuelos; i++)
        {
            int bonusInicial = int.Parse(Console.ReadLine());

            string[] pokeDabriel = Console.ReadLine().Split(' ');
            int ataqueD = int.Parse(pokeDabriel[0]);
            int defesaD = int.Parse(pokeDabriel[1]);
            int levelDabriel = int.Parse(pokeDabriel[2]);

            string[] pokeGuarte = Console.ReadLine().Split(' ');
            int ataqueG = int.Parse(pokeGuarte[0]);
            int defesaG = int.Parse(pokeGuarte[1]);
            int levelGuarte = int.Parse(pokeGuarte[2]);

            int golpeDabriel = CalcularGolpe(ataqueD, defesaD, levelDabriel, bonusInicial);
            int golpeGuarte = CalcularGolpe(ataqueG, defesaG, levelGuarte, bonusInicial);

            if (golpeDabriel > golpeGuarte)
            {
                Console.WriteLine("Dabriel");
            }
            else if (golpeGuarte > golpeDabriel)
            {
                Console.WriteLine("Guarte");
            }
            else
            {
                Console.WriteLine("Empate");
            }
        }
    }

    static int CalcularGolpe(int ataque, int defesa, int levelTreinador, int bonus)
    {
        int golpe = (ataque + defesa) / 2 + bonus;

        if (levelTreinador % 2 == 0)
        {
            golpe += bonus;
        }

        return golpe;
    }
}
