using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] paginaUfpr = entrada.Split(' ');
            int nJogadas = int.Parse(paginaUfpr[0]);
            int ID = int.Parse(paginaUfpr[1]);
            int contarJogadas = 0;

            for (int i = 0; i < nJogadas; i++)
            {
                entrada = Console.ReadLine();
                string[] playersUfpr = entrada.Split(' ');

                int idPlayer = int.Parse(playersUfpr[0]);
                int idJogo = int.Parse(playersUfpr[1]);

                if (idJogo == 0 && idPlayer == ID)
                {
                    contarJogadas++;
                }
            }

            Console.WriteLine(contarJogadas);
        }
    }
}
