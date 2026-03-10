class Program
{
    static void Main()
    {
        GestoreCreazioneUtente gestore = new GestoreCreazioneUtente();

        IObserver log = new ModuloLog();
        IObserver marketing = new ModuloMarketing();

        gestore.Registra(log);
        gestore.Registra(marketing);

        bool continua = true;

        while (continua)
        {
            Console.Write("Inserisci nome utente: ");
            string nome = Console.ReadLine();

            gestore.CreaUtente(nome);
            Console.WriteLine();

            Console.Write("Creare altri utenti? (no per uscire): ");
            string scelta = Console.ReadLine();

            if (scelta.ToLower() == "no") { continua = false; }
        }
    }
}