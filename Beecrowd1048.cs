using System;
using System.Globalization; 
//Developed by @Foqsz, aprendendo!
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste, percentual; ;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            if (salario > 0 && salario <= 400.00)
            {
                percentual = 15;
                novoSalario = salario * percentual / 100 + salario;
                reajuste = salario * percentual / 100;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Em percentual: {percentual + " %"}");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                novoSalario = salario * percentual / 100 + salario;
                reajuste = salario * percentual / 100;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Em percentual: {percentual + " %"}");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                novoSalario = salario * percentual / 100 + salario;
                reajuste = salario * percentual / 100;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Em percentual: {percentual + " %"}");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                novoSalario = salario * percentual / 100 + salario;
                reajuste = salario * percentual / 100;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Em percentual: {percentual + " %"}");
            }
            else
            {
                percentual = 4;
                novoSalario = salario * percentual / 100 + salario;
                reajuste = salario * percentual / 100;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine($"Em percentual: {percentual + " %"}");
            }
        }
    }
}

