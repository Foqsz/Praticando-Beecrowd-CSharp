using System; 
//Developed by @Foqsz
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int grenais = 0;
            int vinter = 0;
            int vgremio = 0;
            int empate = 0;
            int maiorv = 0;

            string[] golsGrenal = Console.ReadLine().Split(' ');
            int inter = int.Parse(golsGrenal[0]);
            int gremio = int.Parse(golsGrenal[1]);
            grenais++;

            if (inter > gremio)
            {
                vinter++;
            }
            else if (gremio > inter)
            {
                vgremio++;
            } 
            else
            {
                empate++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            char grenal = char.Parse(Console.ReadLine());

            while (grenal == '1')
            {
                string[] golsGrenal1 = Console.ReadLine().Split(' ');
                inter = int.Parse(golsGrenal1[0]);
                gremio = int.Parse(golsGrenal1[1]);
                grenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenal = char.Parse(Console.ReadLine());

                if (inter > gremio)
                {
                    vinter++;
                }
                else if (gremio > inter)
                {
                    vgremio++;
                }
                else
                {
                    empate++;
                }

                if (grenal != '1')
                {
                    break;
                }  
            }
            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vinter}");
            Console.WriteLine($"Gremio:{vgremio}");
            Console.WriteLine($"Empates:{empate}");
            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if ( gremio > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}
