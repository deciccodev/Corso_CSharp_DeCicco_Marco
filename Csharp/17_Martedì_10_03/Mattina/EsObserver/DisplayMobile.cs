public class DisplayMobile : IObserver
{
    private readonly string _name;
    private string _observerState;

    public DisplayMobile(string name)
    {
        _name = name;
    }

    public void Update(string newState)
    {
        _observerState = newState;
        if (_observerState != "sole")
        {
            Console.WriteLine($"Stato meteo su {_name} = {_observerState}");
        }
    }
}