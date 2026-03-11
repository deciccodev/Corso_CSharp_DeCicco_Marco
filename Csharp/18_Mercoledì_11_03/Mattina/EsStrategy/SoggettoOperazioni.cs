public class SoggettoOperazioni
{
    private List<IObserver> _observers = new List<IObserver>();

    public void AggiungiObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RimuoviObserver(IObserver o)
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

    //metodo che segnala il cambio stato e quindi chiama il metodo di notifica per gli osservatori
    public void RegistraOperazione(Calcolatrice strategia)
    {
        string descrizione = strategia.Descrizione();

        Notifica($"Operazione eseguita: {descrizione}");
    }
}