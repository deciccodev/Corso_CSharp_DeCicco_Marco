public class DisplayConsole : IObserver
{
    private readonly string _name;
    private string _observerState;

    public DisplayConsole(string name)
    {
        _name = name;
    }

    public void Update(string newState)
    {
        _observerState = newState;
        if (_observerState != "pioggia")
        {
            Console.WriteLine($"Stato meteo su {_name} = {_observerState}");
        }
    }
}