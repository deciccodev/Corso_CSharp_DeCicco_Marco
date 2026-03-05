public class PagamentoCarta : Pagamento
{
    private string _circuito;
    
    public string Circuito
    {
        get { return _circuito;}
        set
        {
            if(!string.IsNullOrEmpty(value))
                _circuito = value;
        }
    }

    public PagamentoCarta(string Circuito)
    {
        this.Circuito = Circuito;
    }

    /*public void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro con carta (Circuito: {Circuito}).");
    }*/

    public override void MostraMetodo()
    {
        Console.WriteLine("Metodo: Carta di credito.");
    }

    public override void EseguiPagamento(decimal Importo)
    {
        Console.WriteLine($"Pagamento di {Importo} euro con carta (Circuito: {Circuito}).");
    }
}