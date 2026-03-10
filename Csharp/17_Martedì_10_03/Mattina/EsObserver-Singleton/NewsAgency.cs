public sealed class NewsAgency : ISubject
{
    private readonly List<IObserverMobile> _observersMobile = new List<IObserverMobile>();
    private readonly List<IObserverEmail> _observersEmail = new List<IObserverEmail>();
    private string _newsMobile;
    private string _newsEmail;
    private static NewsAgency _instance;
    private NewsAgency(){}

    public static NewsAgency GetInstance()
    {
        if (_instance == null)
        {
            _instance = new NewsAgency();
        }
        return _instance;
    }

    public string NewsMobile
    {
        get => _newsMobile;
        set
        {
            _newsMobile = value;
            NotifyMobile(_newsMobile);
        }
    }

    public string NewsEmail
    {
        get => _newsEmail;
        set
        {
            _newsEmail = value;
            NotifyEmail(_newsEmail);
        }
    }

    public void AttachMobile(IObserverMobile observer)
    {
        _observersMobile.Add(observer);
    }

    public void DetachMobile(IObserverMobile observer)
    {
        _observersMobile.Remove(observer);
    }

    public void NotifyMobile(string news)
    {
        foreach (var observer in _observersMobile)
        {
            observer.UpdateMobile(news);
        }
    }

    public void AttachEmail(IObserverEmail observer)
    {
        _observersEmail.Add(observer);
    }

    public void DetachEmail(IObserverEmail observer)
    {
        _observersEmail.Remove(observer);
    }

    public void NotifyEmail(string news)
    {
        foreach (var observer in _observersEmail)
        {
            observer.UpdateEmail(news);
        }
    }
}