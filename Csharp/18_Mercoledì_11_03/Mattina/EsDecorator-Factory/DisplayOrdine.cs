public class DisplayOrdini : IObserver //classe concreta dell'osservatore che riceve gli aggiornamenti dal creatore torte
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"[Display] {messaggio}");
    }
}