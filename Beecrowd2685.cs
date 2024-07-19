using System; 

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int M = int.Parse(entrada.Trim());

            if (M >= 90 && M < 180) { Console.WriteLine("Boa Tarde!!"); }
            else if (M >= 180 && M < 270) { Console.WriteLine("Boa Noite!!"); }
            else if (M >= 0 && M < 90 || M == 360) { Console.WriteLine("Bom Dia!!"); }
            else { Console.WriteLine("De Madrugada!!"); }
        }
    }
}
