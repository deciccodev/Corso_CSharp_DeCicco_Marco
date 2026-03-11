public sealed class CreatoreTorte
{
    //classe subject del pattern observer la quale implementa anche il singleton
    private static CreatoreTorte _instance; //variabile privata dell'istanza della classe

    private List<IObserver> _observers = new List<IObserver>();

    private CreatoreTorte() { }

    public static CreatoreTorte GetInstance() //metodo per ottenere l'istanza della classe
    {
        if (_instance == null)
            _instance = new CreatoreTorte();

        return _instance;
    }

    //metodi per gestire gli osservatori del soggetto (aggiunta, rimozione e notifica)
    public void AggiungiObserver(IObserver o)
    {
        _observers.Add(o);
    }

    private void Notifica(string messaggio)
    {
        foreach (var o in _observers)
        {
            o.Aggiorna(messaggio);
        }
    }

    //metodo che segnala il cambio stato e quindi chiama il metodo di notifica per gli osservatori
    public void RegistraOrdine(ITorta torta)
    {
        string descrizione = torta.Descrizione();

        Console.WriteLine($"Ordine registrato: {descrizione}");

        Notifica($"Nuova torta creata: {descrizione}");
    }
}