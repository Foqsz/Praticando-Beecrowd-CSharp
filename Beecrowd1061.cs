using System;
//Obs: Tive muita dificuldade nesse exércicio. Não foi fácil. Portanto, como sei que vou precisar revisar para algo futuro, fiz questão de comentar cada detalhe para melhor entendimento.
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicito ao usuário a data e hora de início do evento 
            string[] inicioSplit = Console.ReadLine().Split(' '); // Divido a entrada em duas partes: "Dia" e o número do dia
            int diaInicio = int.Parse(inicioSplit[1]); // Extraio o número do dia convertendo-o para inteiro

            string[] horaInicioSplit = Console.ReadLine().Split(':'); // Divido a entrada em três partes: horas, minutos e segundos
            int horaInicio = int.Parse(horaInicioSplit[0]); // Extraio a hora convertendo-a para inteiro
            int minutoInicio = int.Parse(horaInicioSplit[1]); // Extraio os minutos convertendo-os para inteiro
            int segundoInicio = int.Parse(horaInicioSplit[2]); // Extraio os segundos convertendo-os para inteiro

            // Solicito ao usuário a data e hora de término do evento 
            string[] fimSplit = Console.ReadLine().Split(' '); // Divido a entrada em duas partes: "Dia" e o número do dia
            int diaFim = int.Parse(fimSplit[1]); // Extraio o número do dia convertendo-o para inteiro

            string[] horaFimSplit = Console.ReadLine().Split(':'); // Divido a entrada em três partes: horas, minutos e segundos
            int horaFim = int.Parse(horaFimSplit[0]); // Extraio a hora convertendo-a para inteiro
            int minutoFim = int.Parse(horaFimSplit[1]); // Extraio os minutos convertendo-os para inteiro
            int segundoFim = int.Parse(horaFimSplit[2]); // Extraio os segundos convertendo-os para inteiro

            int totalDias = 0, totalHoras = 0, totalMinutos = 0, totalSegundos = 0;

            // Lógica para calcular a duração do evento
            {
                // Criando objetos DateTime para o início e término do evento
                DateTime inicio = new DateTime(2024, 1, diaInicio, horaInicio, minutoInicio, segundoInicio);
                DateTime fim = new DateTime(2024, 1, diaFim, horaFim, minutoFim, segundoFim);

                // Calculando a diferença entre o início e o término do evento
                TimeSpan duracao = fim - inicio;

                // Corrigindo a diferença negativa, caso a data de término seja anterior à data de início
                if (duracao.TotalSeconds < 0)
                {
                    duracao = duracao.Add(TimeSpan.FromDays(1));
                }

                // Extraindo os componentes da duração (dias, horas, minutos e segundos)
                totalDias = duracao.Days;
                totalHoras = duracao.Hours;
                totalMinutos = duracao.Minutes;
                totalSegundos = duracao.Seconds;
            }

            // Exibindo a duração do evento
            Console.WriteLine("Duração do evento:");
            Console.WriteLine("{0} dia(s)", totalDias);
            Console.WriteLine("{0} hora(s)", totalHoras);
            Console.WriteLine("{0} minuto(s)", totalMinutos);
            Console.WriteLine("{0} segundo(s)", totalSegundos);
        }
    }
}
