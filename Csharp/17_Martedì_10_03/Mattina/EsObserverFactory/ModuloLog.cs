public class ModuloLog : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"Notifica modulo LOG nuovo utente: {nomeUtente}");
    }
}