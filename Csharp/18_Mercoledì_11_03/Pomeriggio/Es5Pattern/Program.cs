public class Program
{
    public static void Main(string[] args)
    {
        bool continua = true; //dichiarazione variabile per il loop while

        DisplayOrdini cameriere = new DisplayOrdini(); //creazione dell'observer cameriere
        GestionOrdini gestore = GestionOrdini.GetInstance(); // ottenimento istanza della classe singleton
        gestore.Attach(cameriere); //aggiunta dell'observer alla classe subject

        while (continua)
        {
            Console.WriteLine("\nScegli il tipo di piatto:");
            Console.WriteLine("[1] Pizza");
            Console.WriteLine("[2] Hamburger");
            Console.WriteLine("[3] Insalata");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();
            Console.WriteLine();

            IPiatto piattoBase = PiattoFactory.Crea(scelta); //creazione dell'oggetto base (non decorato)

            piattoBase = Decora(piattoBase); //richiamo alla funzione che si occupa di decorare il piatto base a seconda delle scelte da parte dell'utente

            Console.WriteLine("Scegli il tipo di preparazione:");
            Console.WriteLine("[1] Fritto");
            Console.WriteLine("[2] Al forno");
            Console.WriteLine("[3] Alla griglia");
            Console.Write("Scelta: ");
            string sceltaPreparazione = Console.ReadLine();

            IPreparazioneStategia strategy; //creazione variabile che si occuperà di selezionare la stategia di preparazione dal piatto

            switch (sceltaPreparazione) //in base alla scelta dell'utente utilizzo la strategia desiderata
            {
                case "1":
                    strategy = new StrategyFritto();
                    break;
                case "2":
                    strategy = new StrategyAlForno();
                    break;
                case "3":
                    strategy = new StrategyAllaGriglia();
                    break;
                default:
                    throw new Exception("Scelta di preparazione non valida!\n");
            }

            Chef chef = new Chef(strategy); // creo l'oggetto chef che si occupa della preparazione del piatto passandogli la strategia selezionata dall'utente

            //stampe varie con i risultati della preparazione in console
            Console.WriteLine("\n======= ORDINE =======");
            gestore.RegistraOrdine(piattoBase.Descrizione());
            Console.WriteLine($"Preparazione: {chef.PrepaPiatto(piattoBase)}");

            Console.Write("Preparare un altro piatto? (s/n): ");
            string sceltaLoop = Console.ReadLine();
            if (sceltaLoop.ToLower() == "n")
                continua = false;
        }
    }

    public static IPiatto Decora(IPiatto piattoBase) //passo alla funzione un oggetto IPiatto non ancora decorato
    {
        IPiatto piattoFinale = piattoBase;

        bool loop = true;

        while (loop) //creo un loop per far aggiungere decorazioni al piatto (ingredienti extra) finchè non scegli di uscire
        {
            Console.WriteLine("Aggiungere altro? ");
            Console.WriteLine("[1] Formaggio");
            Console.WriteLine("[2] Bacon");
            Console.WriteLine("[3] Salsa");
            Console.WriteLine("[4] No");
            Console.Write("Scelta: ");
            int sceltaExtra = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (sceltaExtra)
            {
                case 1:
                    piattoFinale = new ConFormaggio(piattoFinale);
                    break;

                case 2:
                    piattoFinale = new ConBacon(piattoFinale);
                    break;

                case 3:
                    piattoFinale = new ConSalsa(piattoFinale);
                    break;

                case 4:
                    loop = false;
                    break;

                default:
                    throw new Exception("Scelta non valida");
            }
        }

        return piattoFinale; // ritorno un oggetto IPiatto decorato
    }
}