using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            //dodo=pedra,leo=papel, pepper=tesoura

            //Os atributos dos monstros vao ser inteligencia, sabedoria... (DODO VENCEDOR)

            //Iron Maiden's gonna get you, no matter how far! (LEO VENCEDOR)

            //Urano perdeu algo muito precioso... (PEPPER VENCEDOR)

            //Putz vei, o Leo ta demorando muito pra jogar... (EMPATE)

            string[] jogo = entrada.Trim().Split(' ');
            string dodo = jogo[0];
            string leo = jogo[1];
            string pepper = jogo[2];

            if (dodo == "pedra" && leo == "tesoura" && pepper == "tesoura")
            {
                Console.WriteLine("Os atributos dos monstros vao ser inteligencia, sabedoria...");
            }
            else if (dodo == "tesoura" && leo == "papel" && pepper == "papel")
            {
                Console.WriteLine("Os atributos dos monstros vao ser inteligencia, sabedoria...");
            }
            else if (dodo == "papel" && leo == "pedra" && pepper == "pedra")
            {
                Console.WriteLine("Os atributos dos monstros vao ser inteligencia, sabedoria...");
            }
            else if (leo == "pedra" && dodo == "tesoura" && pepper == "tesoura")
            {
                Console.WriteLine("Iron Maiden's gonna get you, no matter how far!");
            }
            else if (leo == "tesoura" && dodo == "papel" && pepper == "papel")
            {
                Console.WriteLine("Iron Maiden's gonna get you, no matter how far!");
            }
            else if (leo == "papel" && dodo == "pedra" && pepper == "pedra")
            {
                Console.WriteLine("Iron Maiden's gonna get you, no matter how far!");
            }
            else if (pepper == "pedra" && dodo == "tesoura" && leo == "tesoura")
            {
                Console.WriteLine("Urano perdeu algo muito precioso...");
            }
            else if (pepper == "tesoura" && dodo == "papel" && leo == "papel")
            {
                Console.WriteLine("Urano perdeu algo muito precioso...");
            }
            else if (pepper == "papel" && dodo == "pedra" && leo == "pedra")
            {
                Console.WriteLine("Urano perdeu algo muito precioso...");
            }
            else
            {
                Console.WriteLine("Putz vei, o Leo ta demorando muito pra jogar...");
            }

        }

    }
}
