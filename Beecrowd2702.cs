using System; 

class Program
{
    static void Main(string[] args)
    {
        string[] disponiveis = Console.ReadLine().Split(' ');
        int onFrango = int.Parse(disponiveis[0]);
        int onBife = int.Parse(disponiveis[1]);
        int onMassa = int.Parse(disponiveis[2]);

        string[] pedido = Console.ReadLine().Split(' ');
        int pFrango = int.Parse(pedido[0]);
        int pBife = int.Parse(pedido[1]);
        int pMassa = int.Parse(pedido[2]);

        int qntFrango = 0, qntBife = 0, qntMassa = 0;

        if (pFrango > onFrango) { qntFrango = pFrango - onFrango; }
        if (pBife > onBife) { qntBife = pBife - onBife; }
        if (pMassa > onMassa) { qntMassa = pMassa - onMassa; }

        int result = qntFrango + qntBife + qntMassa;

        Console.WriteLine(result);
    }

}
