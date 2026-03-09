public sealed class Logger
{
    private static Logger _instance;

    private static readonly object _lock = new object();

    private Logger()
    {
        //codice di inizializzazione
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now}] - {messaggio}");
    }
}
