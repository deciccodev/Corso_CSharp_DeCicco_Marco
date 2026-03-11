public class DisplayConsole : IObserver
{
    public void Update(string messaggio)
    {
        Console.WriteLine($"[Display] {messaggio}");
    }
}