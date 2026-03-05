public class PagamentoContanti : Pagamento
{
    /*public void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro in contanti.");
    }*/

    public override void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro in contanti.");
    }

    public override void MostraMetodo()
    {
        Console.WriteLine("Metodo: Contanti.");
    }
}