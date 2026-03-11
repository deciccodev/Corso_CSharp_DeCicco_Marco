public class DisplayOrdini : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"[Display] {messaggio}");
    }
}