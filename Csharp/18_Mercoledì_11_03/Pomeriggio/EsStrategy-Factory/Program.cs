public class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context();

        Console.WriteLine("Scegli metodo di pagamento");
        Console.WriteLine("[1] Carta di credito");
        Console.WriteLine("[2] PayPal");
        Console.WriteLine("[3] Bitcoin");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine();

        IPaymentStrategy stategy = PaymentFactory.CreaPagamento(scelta);

        context.ImpostaStrategia(stategy);
        context.Pay(100m);
    }
}