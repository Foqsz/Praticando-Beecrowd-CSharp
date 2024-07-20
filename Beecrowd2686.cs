using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            double M = double.Parse(entrada.Trim(), CultureInfo.InvariantCulture);

            string periodo;
            if (M >= 90 && M < 180)
            {
                periodo = "Boa Tarde!!";
            }
            else if (M >= 180 && M < 270)
            {
                periodo = "Boa Noite!!";
            }
            else if (M >= 0 && M < 90 || M == 360)
            {
                periodo = "Bom Dia!!";
            }
            else
            {
                periodo = "De Madrugada!!";
            }

            string saberH = SaberHora(M);
            Console.WriteLine(periodo);
            Console.WriteLine(saberH);
        }
    }
     
    static int converte(double angulo)
    {
        return (int)(angulo * 240);
    }

    static int tempoDecorrido(double angulo)
    {
        return (converte(angulo) + converte(90)) % converte(360);
    }

    static string SaberHora(double M)
    {
        int tempo = tempoDecorrido(M);
        int hours = tempo / 3600;
        int totalSeconds = (int)(M * 240); // 360 graus correspondem a 86400 segundos (24h * 3600s) 
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
}
