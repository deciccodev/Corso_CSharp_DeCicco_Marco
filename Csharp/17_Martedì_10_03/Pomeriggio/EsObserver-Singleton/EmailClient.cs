public class EmailClient : IObserverEmail
{
    private string _observerState;

    public void UpdateEmail(string newState)
    {
        _observerState = newState;
        Console.WriteLine($"Email sent: {_observerState}");
    }
}