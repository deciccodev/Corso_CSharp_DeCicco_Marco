public class PagamentoPayPal : Pagamento
{
    private string _emailUtente;
    
    public string EmailUtente
    {
        get { return _emailUtente;}
        set
        {
            if(!string.IsNullOrEmpty(value))
                _emailUtente = value;
        }
    }

    public PagamentoPayPal(string EmailUtente)
    {
        this.EmailUtente = EmailUtente;
    }

    /*public void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro tramite PayPal da: {EmailUtente}.");
    }*/

    public override void MostraMetodo()
    {
        Console.WriteLine("Metodo: PayPal.");
    }

    public override void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro tramite PayPal da: {EmailUtente}.");
    }
}