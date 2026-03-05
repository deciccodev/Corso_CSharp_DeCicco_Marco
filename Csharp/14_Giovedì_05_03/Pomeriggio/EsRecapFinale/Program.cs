class Program
{
    static void Main()
    {
        List<Persona> persone = new List<Persona>();

        Log log = new Log();
        AccessController controller = new AccessController(log);

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\n--- GESTIONALE ACCESSI AZIENDALI ---");
            Console.WriteLine("[1] Crea impiegato");
            Console.WriteLine("[2] Entra in azienda");
            Console.WriteLine("[3] Esci dall'azienda");
            Console.WriteLine("[4] Mostra log");
            Console.WriteLine("[5] Mostra la lista degli impiegati");
            Console.WriteLine("[6] Esci");

            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":

                    Console.Write("Nome impiegato: ");
                    string nome = Console.ReadLine();

                    Console.Write("Cognome impiegato: ");
                    string cognome = Console.ReadLine();

                    Console.Write("Codice badge: ");
                    int codice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Seleziona il ruolo dell'impiegato:");
                    Console.WriteLine("[0] Dipendente");
                    Console.WriteLine("[1] Manager");
                    Console.WriteLine("[2] Amministratore");

                    int ruoloInput = int.Parse(Console.ReadLine());

                    Ruoli ruolo = (Ruoli)ruoloInput;

                    Badge badge = new Badge(codice);

                    Impiegato impiegato = new Impiegato(nome, cognome, badge, ruolo);

                    persone.Add(impiegato);

                    Console.WriteLine("Impiegato creato.");
                    controller.Registrazione(impiegato);

                    break;

                case "2":

                    if (persone.Count == 0)
                    {
                        Console.WriteLine("Nessun impiegato registrato in azienda.");
                        break;
                    }

                    StampaPersone(persone);

                    Console.Write("Seleziona impiegato in entrata: ");
                    int indexEntrata = int.Parse(Console.ReadLine());

                    controller.Entrata(persone[indexEntrata]);

                    break;

                case "3":

                    if (persone.Count == 0)
                    {
                        Console.WriteLine("Nessun impiegato registrato in azienda.");
                        break;
                    }

                    StampaPersone(persone);

                    Console.Write("Seleziona impiegato in uscita: ");
                    int iUscita = int.Parse(Console.ReadLine());

                    controller.Uscita(persone[iUscita]);

                    break;

                case "4":

                    controller.MostraLog();

                    break;

                case "5":

                    StampaPersone(persone);

                    break;

                case "6":

                    continua = false;

                    break;
            }
        }
    }

    static void StampaPersone(List<Persona> persone)
    {
        Console.WriteLine("\nPersone registrate in azienda:");

        for (int i = 0; i < persone.Count; i++)
        {
            Console.WriteLine($"{i} - {persone[i]}");
        }
    }
}