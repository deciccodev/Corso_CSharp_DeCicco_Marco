public class ModuloMarketing : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"Notifica modulo MARKETING nuovo utente: {nomeUtente}");
    }
}