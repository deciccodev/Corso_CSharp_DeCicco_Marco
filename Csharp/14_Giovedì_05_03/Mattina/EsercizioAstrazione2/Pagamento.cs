public abstract class Pagamento : IPagamento

{
    public abstract void EseguiPagamento(decimal importo);

    public virtual void MostraMetodo()
    {
        Console.WriteLine("Metodo di pagamento generico");
    }
}