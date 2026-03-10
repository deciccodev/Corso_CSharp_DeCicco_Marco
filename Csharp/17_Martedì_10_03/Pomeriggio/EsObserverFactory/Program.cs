public class Program
{
    public static void Main(string[] args)
    {
        GestoreCreazioneUtente gestore = GestoreCreazioneUtente.GetInstance();

        IObserver log = new ModuloLog();
        IObserver marketing = new ModuloMarketing();

        gestore.Registra(log);
        gestore.Registra(marketing);

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("[1] Inserisci Utente");
            Console.WriteLine("[2] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci nome utente: ");
                    string nome = Console.ReadLine();

                    gestore.CreaUtente(nome);
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Escita programma...");
                    continua = false;
                    Console.WriteLine();
                    break;
                default:
                    throw new Exception("Scelta non valida");
            }
        }
    }
}