public class Program
{
    public static void Main(string[] args)
    {
        bool continua = true;

        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        while (continua)
        {
            Console.WriteLine("======== CLIENT LOGS ========");
            Console.WriteLine("[1] Inserisci log da Logger 1");
            Console.WriteLine("[2] Inserisci log da Logger 2");
            Console.WriteLine("[3] Stampa tutto da Logger");
            Console.WriteLine("[4] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();
            Console.WriteLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Scrivi il messaggio da inserire: ");
                    string txtL1 = Console.ReadLine();
                    logger1.Log(txtL1);
                    Console.WriteLine($"HashCode del logger usato: {logger1.GetHashCode()}");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.Write("Scrivi il messaggio da inserire: ");
                    string txtL2 = Console.ReadLine();
                    logger2.Log(txtL2);
                    Console.WriteLine($"HashCode del logger usato: {logger2.GetHashCode()}");
                    Console.WriteLine();
                    break;

                case "3":
                    Logger.Instance.StampaTutte();
                    Console.WriteLine();
                    break;
                case "4":
                    
                    continua = false;
                    Console.WriteLine("Chiusura programma...");
                    break;

                default:
                    throw new Exception("Errore scelta");
            }
        }
    }
}