public sealed class Logger
{
    private static Logger? _instance;

    private static readonly object _lock = new object();
    private List<string> listaLogs = new List<string>();

    private Logger()
    {
        //codice di inizializzazione
    }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        listaLogs.Add(message);
        Console.WriteLine("Log aggiunto alla lista!");
    }

    public void StampaTutte()
    {
        Console.WriteLine($"Stampa di tutti i log presenti:");
        foreach (var v in listaLogs)
        {
            Console.WriteLine($"{v}");
        }
    }
}
