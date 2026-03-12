public class Logger : IObserver
{
    public void Update(string messaggio)
    {
        Console.WriteLine($"[LOG] {messaggio}");
    }
}