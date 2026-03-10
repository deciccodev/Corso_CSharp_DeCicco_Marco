public class CentroMeteo : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private string _state;

    // Proprietà dello stato; quando cambia, notifica gli observer, DIVERSI TIPI DI OBSERVER RICHIEDONO DIVERSI METODI DI SET DELLO STATE a secondi di quale observer vogliamo cambiare
    public string State
    {
        get => _state;
        set
        {
            _state = value;
            Notify(_state);
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string messaggio)
    {
        foreach (var observer in _observers)
        {
            observer.Update(messaggio);
        }
    }

    public void AggiornaMeteo(string dati)
    {
        Console.WriteLine("Meteo aggiornato!");
        Notify(dati);
    }
}