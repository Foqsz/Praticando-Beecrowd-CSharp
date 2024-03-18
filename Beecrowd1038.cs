    using System;
    using System.Globalization;

 //by @Foqsz
  namespace Course
    {
        class Program
        {
            static void Main(string[] args)
            {
                /*Console.WriteLine("----------------------------");
                Console.WriteLine("CODIGO | ESPECIFICACAO | PRECO");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Cachorro Quente - R$4.50");
                Console.WriteLine("2 - X Salada - R$4.50");
                Console.WriteLine("3 - X Bacon - R$5.00");
                Console.WriteLine("4 - Torrada Simples - R$2.00");
                Console.WriteLine("5 - Refrigerante - R$1.50");
                Console.WriteLine("----------------------------");

                Console.Write("Qual o seu pedido? (Digite: ID Do Pedido e Quantidade): ");*/

                string[] pedidos = Console.ReadLine().Split(' ');
                int idPedido = int.Parse(pedidos[0]);
                int quantidade = int.Parse(pedidos[1]);

                double total; 
                if (idPedido == 1)
                {
                    total = quantidade * 4.0; 
                }
                else if (idPedido == 2)
                {
                    total = quantidade * 4.5; 
                }
                else if (idPedido == 3)
                {
                    total = quantidade * 5.0; 
                }
                else if (idPedido == 4)
                {
                    total = quantidade * 2.0;  
                }
                else
                {
                    total = quantidade * 1.5; 
                }
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
