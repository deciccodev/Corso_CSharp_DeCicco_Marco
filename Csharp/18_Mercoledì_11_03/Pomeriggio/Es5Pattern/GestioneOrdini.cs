public sealed class GestionOrdini //subject del pattern observer e classe instanziata per racchiudere il singleton
{
    private static GestionOrdini _instance;

    private List<IObserver> _observers = new List<IObserver>();

    private GestionOrdini() { }

    public static GestionOrdini GetInstance() //metodo che fornisce l'istanza singleton all'esetrno della classe
    {
        if (_instance == null)
            _instance = new GestionOrdini();

        return _instance;
    }

    //metodi di aggiunta, rimozione e notifica del pattern observer
    public void Attach(IObserver o)
    {
        _observers.Add(o);
    }

    public void Detach(IObserver o)
    {
        _observers.Remove(o);
    }

    private void Notifica(string messaggio)
    {
        foreach (var o in _observers)
        {
            o.Update(messaggio);
        }
    }

    public void RegistraOrdine(string piatto)
    {
        string descrizione = piatto;

        Notifica($"Piatto ordinato: {descrizione}");
    }
}