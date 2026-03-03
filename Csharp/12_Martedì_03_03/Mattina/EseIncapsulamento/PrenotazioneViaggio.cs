public class PrenotazioneViaggio
{
    const int MAX_POSTI = 20;

    private int _postiPrenotati;
    private string _destinazione;

    public string Destinazione
    {
        get { return _destinazione; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _destinazione = value;
            else
                Console.WriteLine("Destinazione non valida");
        }
    }

    public int PostiDisponibili
    {
        get { return MAX_POSTI - _postiPrenotati; }
    }

    public int PostiPrenotati
    {
        get { return _postiPrenotati; }
    }

    public PrenotazioneViaggio(string Destinazione)
    {
        this.Destinazione = Destinazione;
    }

    public void PrenotaPosti(int numeroPosti)
    {
        if (numeroPosti > 0 && PostiDisponibili >= numeroPosti)
        {
            _postiPrenotati += numeroPosti;
            Console.WriteLine("Prenotazione effettuata!");
        }
        else
        {
            Console.WriteLine("Posti insufficienti o numero non valido.");
        }
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= _postiPrenotati)
        {
            _postiPrenotati -= numeroPosti;
            Console.WriteLine("Prenotazione annullata!");
        }
        else
        {
            Console.WriteLine("Numero non valido per l'annullamento.");
        }
    }

    public void PrenotaVolo()
    {
        Console.Write("Inserisci destinazione volo: ");
        string destinazione = Console.ReadLine();

        PrenotazioneViaggio prenota = new PrenotazioneViaggio(destinazione);

        Console.WriteLine($"destinazione volo: {prenota.Destinazione}");
        Console.WriteLine($"posti disponibili prima della prenotazione: {prenota.PostiDisponibili}");

        Console.Write("Quanti posti prenotare?: ");
        int postiPrenotazione = int.Parse(Console.ReadLine());
        Console.WriteLine();

        prenota.PrenotaPosti(postiPrenotazione);
        Console.WriteLine($"posti disponibili dopo della prenotazione: {prenota.PostiDisponibili}");

        Console.Write("Quanti posti annullare?: ");
        int annullaPosti = int.Parse(Console.ReadLine());
        Console.WriteLine();

        prenota.AnnullaPrenotazione(annullaPosti);
        Console.WriteLine($"posti disponibili dopo annullo prenotazione: {prenota.PostiDisponibili}");
    }
}