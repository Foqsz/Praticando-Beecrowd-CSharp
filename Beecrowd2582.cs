using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> Musica = new Dictionary<int, string>();

        Musica.Add(0, "PROXYCITY");
        Musica.Add(1, "P.Y.N.G.");
        Musica.Add(2, "DNSUEY!");
        Musica.Add(3, "SERVERS");
        Musica.Add(4, "HOST!");
        Musica.Add(5, "CRIPTONIZE");
        Musica.Add(6, "OFFLINE DAY");
        Musica.Add(7, "SALT");
        Musica.Add(8, "ANSWER!");
        Musica.Add(9, "RAR?");
        Musica.Add(10, "WIFI ANTENNAS");  

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] pedirMusica = Console.ReadLine().Split(' ');
            int op1 = int.Parse(pedirMusica[0]);
            int op2 = int.Parse(pedirMusica[1]);

            int aMusicaE = op1 + op2;

            Console.WriteLine(Musica[aMusicaE]); 
        }

    }
}
