using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                int casosDeTeste = int.Parse(entrada);

                if (casosDeTeste == 0) break;

                string planetaMaisAntigo = null;
                int anoMaisAntigo = int.MaxValue;

                for (int i = 0; i < casosDeTeste; i++)
                {
                    string[] planetas = Console.ReadLine().Split(' ');
                    string namePlaneta = planetas[0];
                    int anoMsgRecebida = int.Parse(planetas[1]);
                    int anoMsgEnviada = int.Parse(planetas[2]);

                    int anoDeEnvio = anoMsgRecebida - anoMsgEnviada;

                    if (anoDeEnvio < anoMaisAntigo)
                    {
                        anoMaisAntigo = anoDeEnvio;
                        planetaMaisAntigo = namePlaneta;
                    }
                }

                Console.WriteLine(planetaMaisAntigo);
            }

        }
    }
}
