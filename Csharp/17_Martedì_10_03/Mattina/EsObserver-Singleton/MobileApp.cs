public class MobileApp : IObserverMobile
{
    private string _observerState;

    public void UpdateMobile(string newState)
    {
        _observerState = newState;
        Console.WriteLine($"Notification on mobile: {_observerState}");
    }
}