public class Context
{
    private IPaymentStrategy _strategiaPagamento;

    public void Pay(decimal amount)
    {
        _strategiaPagamento.Pay(amount);
    }

    public void ImpostaStrategia(IPaymentStrategy nuovaStrategia)
    {
        _strategiaPagamento = nuovaStrategia;
    }
}