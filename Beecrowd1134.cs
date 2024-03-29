using System;
//Developed by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //armanezando as variaveis no exercicio;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (true) //Variavel while para ficar repetindo ate que ela seja encerrada com break;
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada < 1 && entrada > 4)
                {
                    entrada = int.Parse(Console.ReadLine());
                }
                else if (entrada == 1)
                {
                    alcool++;
                }
                else if (entrada == 2)
                {
                    gasolina++;
                }
                else if (entrada == 3)
                {
                    diesel++;
                }
                else if (entrada == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                    break;
                }
            }
        }
    }
}
