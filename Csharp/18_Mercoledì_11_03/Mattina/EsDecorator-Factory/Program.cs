public class Program
{
    public static void Main(string[] args)
    {
        CreatoreTorte creatoreTorte = CreatoreTorte.GetInstance();

        creatoreTorte.AggiungiObserver(new DisplayOrdini());

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("Scegli una torta base");
            Console.WriteLine("[1] Torta al cioccolato");
            Console.WriteLine("[2] Torta alla Vaniglia");
            Console.WriteLine("[3] Torta alla frutta");
            Console.WriteLine("[4] Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    ITorta tortaCioccolato = TortaFactory.CreaTortaBase("cioccolato");
                    Console.WriteLine($"Al momento hai una {tortaCioccolato.Descrizione()}");
                    Console.WriteLine();
                    Decora(tortaCioccolato);
                    break;

                case 2:
                    ITorta tortaVaniglia = TortaFactory.CreaTortaBase("vaniglia");
                    Console.WriteLine($"Al momento hai una {tortaVaniglia.Descrizione()}");
                    Console.WriteLine();
                    Decora(tortaVaniglia);
                    break;

                case 3:
                    ITorta tortaFrutta = TortaFactory.CreaTortaBase("frutta");
                    Console.WriteLine($"Al momento hai una {tortaFrutta.Descrizione()}");
                    Console.WriteLine();
                    Decora(tortaFrutta);
                    break;
                    
                case 4:
                    Console.WriteLine("Uscita programma...");
                    Console.WriteLine();
                    continua = false;
                    break;
                default:
                    throw new Exception("Scelta non valida");
            }
        }
    }

    public static void Decora(ITorta torta)
    {
        ITorta tortaFinale = torta;

        bool loop = true;

        while (loop)
        {
            Console.WriteLine("Aggiungere altro? ");
            Console.WriteLine("[1] Panna");
            Console.WriteLine("[2] Fragole");
            Console.WriteLine("[3] Glassa");
            Console.WriteLine("[4] No");
            Console.Write("Scelta: ");
            int sceltaExtra = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (sceltaExtra)
            {
                case 1:
                    tortaFinale = new DecoratorePanna(tortaFinale);
                    break;

                case 2:
                    tortaFinale = new DecoratoreFragola(tortaFinale);
                    break;

                case 3:
                    tortaFinale = new DecoratoreGlassa(tortaFinale);
                    break;

                case 4:
                    loop = false;
                    break;

                default:
                    throw new Exception("Scelta non valida");
            }
        }

        Console.WriteLine(tortaFinale.Descrizione());
        CreatoreTorte.GetInstance().RegistraOrdine(tortaFinale);
        Console.WriteLine();
    }
}