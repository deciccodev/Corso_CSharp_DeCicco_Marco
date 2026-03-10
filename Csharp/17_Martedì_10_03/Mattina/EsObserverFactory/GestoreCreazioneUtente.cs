public class GestoreCreazioneUtente : ISoggetto
{
    private readonly List<IObserver> _o = new List<IObserver>();

    public void Registra(IObserver observer)
    {
        _o.Add(observer);
    }

    public void Rimuovi(IObserver observer)
    {
        _o.Remove(observer);
    }

    public void Notifica(string nomeUtente)
    {
        foreach (var observer in _o)
        {
            observer.NotificaCreazione(nomeUtente);
        }
    }
    
    public void CreaUtente(string nomeUtente)
    {
        Utente u = UserFactory.Crea(nomeUtente);
        Console.WriteLine(u);

        Notifica(nomeUtente);
    }
}