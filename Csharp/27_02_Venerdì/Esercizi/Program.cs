class Program
{
    public static void Main(string[] args)
    {
        //EsercizioStudente();
        //EsercizioPersona();
        //EsercizioOperazioni();        
    }

    public static void EsercizioStudente()
    {
        Studente s1 = new Studente("Francesco", 123, 8.35d);
        Studente s2 = new Studente("Ciro", 456, 8.35d);

        Console.WriteLine($"Info studente 1: {s1.nome}, {s1.matricola}, {s1.mediaVoti}");
        Console.WriteLine($"Info studente 2: {s2.nome}, {s2.matricola}, {s2.mediaVoti}");
    }

    public static void EsercizioPersona()
    {
        Persona p1 = new Persona();
        Persona p2 = new Persona();

        p1.nome = "Mario";
        p1.cognome = "Rossi";
        p1.annoNascita = 1990;

        p2.nome = "Giuseppe";
        p2.cognome = "Verdi";
        p2.annoNascita = 2000;

        Console.WriteLine($"{p1.nome} {p1.cognome} è nato nel {p1.annoNascita}");
        Console.WriteLine($"{p2.nome} {p2.cognome} è nato nel {p2.annoNascita}");
    }

    public static void EsercizioOperazioni()
    {
        bool continua = true;

        do
        {
            Console.Write("Inserisci primo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            
            Operazioni operazione = new Operazioni();

            int somma = 0, moltiplica = 0;

            somma = operazione.Somma(n1, n2);
            moltiplica = operazione.Moltiplica(n1, n2);

            operazione.StampaRisultato("Somma", somma);
            operazione.StampaRisultato("Moltiplica", moltiplica);

            Console.Write("Vuoi ripetere l'operazione? (si/no): ");
            string scelta = Console.ReadLine().ToLower();

            if(scelta == "no"){continua = false; break;}
            Console.WriteLine();
        } while (continua);
        
    }
}