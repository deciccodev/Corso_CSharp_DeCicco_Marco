public static class PaymentFactory
{
    public static IPaymentStrategy CreaPagamento(string scelta)
    {
        string tipo = scelta.ToLower();

        switch (tipo)
        {
            case "1":
                return new CreditCardPayment();
            case "2":
                return new PayPalPayment();
            case "3":
                return new BitcoinPayment();
            default:
                throw new ArgumentException("Scelta non valida!");
        }
    }
}