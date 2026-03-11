public class CreatoreTorte
{
    private static CreatoreTorte _instance;

    private List<IObserver> _observers = new List<IObserver>();

    private CreatoreTorte() { }

    public static CreatoreTorte GetInstance()
    {
        if (_instance == null)
            _instance = new CreatoreTorte();

        return _instance;
    }

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

    public void RegistraOrdine(ITorta torta)
    {
        string descrizione = torta.Descrizione();

        Console.WriteLine($"Ordine registrato: {descrizione}");

        Notifica($"Nuova torta creata: {descrizione}");
    }
}