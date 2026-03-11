public class Program
{
    public static void Main(string[] args)
    {
        Calcolatrice context = new Calcolatrice();

        DisplayConsole o = new DisplayConsole();
        SoggettoOperazioni soggetto = new SoggettoOperazioni();

        soggetto.AggiungiObserver(o);

        bool continua = true;
        
        while (continua)
        {
            int a = 0, b = 0;
            Console.WriteLine("Che strategia utilizzare?");
            Console.WriteLine("[1] Somma");
            Console.WriteLine("[2] Sottrazione");
            Console.WriteLine("[3] Moltiplicazione");
            Console.WriteLine("[4] Divisione");
            Console.WriteLine("[5] Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());
            if (scelta != 5)
            {
                Console.Write("Inserisci primo numero: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Inserisci secondo numero: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();                
            }

            switch (scelta)
            {
                case 1:
                    context.ImpostaStrategia(new StrategiaSomma());
                    Console.WriteLine($"La Somma dei due numeri è: {context.EseguiOperazione(a, b)}");
                    soggetto.RegistraOperazione(context);
                    Console.WriteLine();
                    break;
                case 2:
                    context.ImpostaStrategia(new StrategiaSottrazione());
                    Console.WriteLine($"La Sottrazione dei due numeri è: {context.EseguiOperazione(a, b)}");
                    soggetto.RegistraOperazione(context);
                    Console.WriteLine();
                    break;
                case 3:
                    context.ImpostaStrategia(new StrategiaMoltiplicazione());
                    Console.WriteLine($"La Moltiplicazione dei due numeri è: {context.EseguiOperazione(a, b)}");
                    soggetto.RegistraOperazione(context);
                    Console.WriteLine();
                    break;
                case 4:
                    context.ImpostaStrategia(new StrategiaDivisione());
                    Console.WriteLine($"La Divisione dei due numeri è: {context.EseguiOperazione(a, b)}");
                    soggetto.RegistraOperazione(context);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Uscita...");
                    continua = false;
                    Console.WriteLine();
                    break;
                default:
                    throw new Exception("Scelta non valida!\n");
            }
        }
    }
}