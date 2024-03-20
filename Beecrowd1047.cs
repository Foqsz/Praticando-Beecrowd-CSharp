using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicioMinuto, terminoMinuto, resultado, finalHoras, finalMinutos;

            string[] soma = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(soma[0]);
            int minutoInicial = int.Parse(soma[1]);
            int horaFinal = int.Parse(soma[2]);
            int minutoFinal = int.Parse(soma[3]);

            inicioMinuto = horaInicial * 60 + minutoInicial;
            terminoMinuto = horaFinal * 60 + minutoFinal;

            if (terminoMinuto <= inicioMinuto)
            {
                resultado = 24 * 60 - inicioMinuto + terminoMinuto;
            }
            else
            {
                resultado = terminoMinuto - inicioMinuto;
            }

            finalHoras = resultado / 60;
            finalMinutos = resultado % 60;

            Console.WriteLine($"O JOGO DUROU {finalHoras} HORA(S) E {finalMinutos} MINUTO(S)");
        }
    }
}
