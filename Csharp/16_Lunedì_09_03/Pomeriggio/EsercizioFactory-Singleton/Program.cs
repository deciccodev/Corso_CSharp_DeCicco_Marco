public class Program
{
    public static void Main(string[] args)
    {
        bool continua = true;

        RegistroVeicoli sVeicolo = RegistroVeicoli.GetInstance();

        while (continua)
        {
            Console.WriteLine("======== MENU VEICOLI ========");
            Console.WriteLine("[1] Inserisci Auto");
            Console.WriteLine("[2] Inserisci Moto");
            Console.WriteLine("[3] Inserisci Camion");
            Console.WriteLine("[4] Stampa veicoli");
            Console.WriteLine("[5] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();
            Console.WriteLine();

            switch (scelta)
            {
                case "1":
                    IVeicolo auto = VeicoloFactory.CreaVeicolo("auto");
                    auto.Avvia();
                    sVeicolo.Registra(auto);
                    break;

                case "2":
                    IVeicolo moto = VeicoloFactory.CreaVeicolo("moto");
                    moto.Avvia();
                    sVeicolo.Registra(moto);
                    break;

                case "3":
                    IVeicolo camion = VeicoloFactory.CreaVeicolo("camion");
                    camion.Avvia();
                    sVeicolo.Registra(camion);
                    break;
                
                case "4":
                    sVeicolo.StampaVeicoli();
                    break;

                case "5":
                    
                    continua = false;
                    Console.WriteLine("Chiusura programma...");
                    break;

                default:
                    throw new Exception("Errore scelta");
            }
        }
    }
}