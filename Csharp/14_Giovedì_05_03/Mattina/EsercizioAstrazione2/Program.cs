public class Program
{
    public static void Main(string[] args)
    {
        List<Pagamento> pagamenti = new List<Pagamento>()
        {
            new PagamentoCarta("Mastercard"),
            new PagamentoContanti(),
            new PagamentoPayPal("utente@email.com"),
        };

        Console.Write("Importo da pagare: ");
        int importo = int.Parse(Console.ReadLine());
        Console.WriteLine();

        foreach (Pagamento p in pagamenti)
        {
            p.MostraMetodo();
            p.EseguiPagamento(importo);
            Console.WriteLine();
        }
    }
}