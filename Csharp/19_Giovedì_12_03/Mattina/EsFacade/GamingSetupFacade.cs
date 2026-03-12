public sealed class GamingSetupFacade
{
    private Monitor _monitor;
    private SchedaVideo _schedaVideo;
    private Tastiera _tastiera;
    private Mouse _mouse;

    private static GamingSetupFacade _instance;

    private List<IObserver> _observers = new List<IObserver>();

    private GamingSetupFacade(Monitor monitor, SchedaVideo schedaVideo, Tastiera tastiera, Mouse mouse)
    {
        _monitor = monitor;
        _schedaVideo = schedaVideo;
        _tastiera = tastiera;
        _mouse = mouse;
    }

    public static GamingSetupFacade GetInstance(Monitor monitor, SchedaVideo schedaVideo, Tastiera tastiera, Mouse mouse)
    {
        if (_instance == null)
        {
            _instance = new GamingSetupFacade(monitor, schedaVideo, tastiera, mouse);
        }

        return _instance;
    }

    public void StartSetup()
    {
        string messaggio =  "Avvio della postazione gaming...";
        Notifica(messaggio);
        _monitor.Accendi();
        _tastiera.Collega();
        _mouse.Inizializza();
        _schedaVideo.Inizializza();
    }
    
    public void SpegniSetup()
    {
        string messaggio = "Arresto della postazione gaming...";
        Notifica(messaggio);
        _monitor.Spegni();
        _tastiera.Scollega();
        _mouse.Spegni();
        _schedaVideo.Spegni();
    }

    public void Attach(IObserver o)
    {
        _observers.Add(o);
    }

    public void Detach(IObserver o)
    {
        _observers.Remove(o);
    }

    private void Notifica(string messaggio)
    {
        foreach (var o in _observers)
        {
            o.Update(messaggio);
        }
    }
}