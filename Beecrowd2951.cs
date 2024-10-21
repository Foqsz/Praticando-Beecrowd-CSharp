using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler a quantidade de runas e a quantidade de amizade necessária
            string[] quantRunasAmizades = Console.ReadLine().Split(' ');
            int runas = int.Parse(quantRunasAmizades[0]);
            int amizadeNecessaria = int.Parse(quantRunasAmizades[1]);

            // Dicionário para armazenar o valor de amizade de cada runa
            Dictionary<char, int> runasValores = new Dictionary<char, int>();

            // Ler as runas e seus valores
            for (int i = 0; i < runas; i++)
            {
                string[] disputa = Console.ReadLine().Split(' ');
                char runaLetra = char.Parse(disputa[0]);
                int runaValor = int.Parse(disputa[1]);

                // Armazenar no dicionário
                runasValores[runaLetra] = runaValor;
            }

            // Ler a quantidade de runas recitadas e as runas recitadas
            int runasRecitadas = int.Parse(Console.ReadLine());
            string[] runasCitada = Console.ReadLine().Split(' ');

            // Calcular o valor total de amizade
            int totalAmizade = 0;
            for (int i = 0; i < runasRecitadas; i++)
            {
                char runa = char.Parse(runasCitada[i]);
                totalAmizade += runasValores[runa];
            }

            // Exibir o valor total de amizade
            Console.WriteLine(totalAmizade);

            // Verificar se Frodo e Sam conseguiram derrotar Gollum
            if (totalAmizade >= amizadeNecessaria)
            {
                Console.WriteLine("You shall pass!");
            }
            else
            {
                Console.WriteLine("My precioooous");
            }
        }
    }
}
