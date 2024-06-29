using System;
class Program
{
    static void Main(string[] args)
    {
        string entrada;
        int ano = 360;
        int diaMes = 31;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] numeros = entrada.Split(' ');
            int mes = int.Parse(numeros[0]);
            int dia = int.Parse(numeros[1]);

            if (mes == 12 && dia == 24)
            {
                Console.WriteLine("E vespera de natal!");
            }
            else if (mes <= 12 && dia <= 31)
            {
                DateTime dataAtual = DateTime.Today;

                DateTime natal = new DateTime(dataAtual.Year, 12, 25);

                TimeSpan diferenca = natal - new DateTime(dataAtual.Year, mes, dia);
                int diasFaltando = diferenca.Days;

                if (diasFaltando < 0)
                {
                    Console.WriteLine("Ja passou!");
                }
                else if (diasFaltando == 0)
                {
                    Console.WriteLine("E natal!");
                }
                else
                {
                    Console.WriteLine($"Faltam {diasFaltando} dias para o natal!");
                }
            }
            else if (mes == 12 && dia > 25)
            {
                Console.WriteLine("Ja passou!");
            }
            else if (mes == 12 && dia == 25)
            {
                Console.WriteLine("E natal!");
            }
        }
    }
}

