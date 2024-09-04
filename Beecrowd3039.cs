using System; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCasos = int.Parse(Console.ReadLine());
            int carrinho = 0, boneca = 0;
            for (int i = 0; i < nCasos; i++)
            {
                string[] criancasPresentes = Console.ReadLine().Split(' ');
                string name = criancasPresentes[0];
                string genero = criancasPresentes[1];

                if (genero == "F")
                {
                    boneca++;
                }
                else
                {

                    carrinho++;
                }
            }
            Console.WriteLine($"{carrinho} carrinhos");
            Console.WriteLine($"{boneca} bonecas"); 
        }
    }
}
