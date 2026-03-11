public class DisplayOrdini : IObserver //classe concreta dell'osservatore
{
    public void Update(string messaggio)
    {
        Console.WriteLine($"[Display] {messaggio}");
    }
}