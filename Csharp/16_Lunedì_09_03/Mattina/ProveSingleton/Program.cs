public sealed class Singleton
{
    //riferimento unica istanza singleton (inizialmente null)
    private static Singleton _instance;

    //oggetto di lock per garantire thread-safety
    private static readonly object _lock = new object();

    //costruttore privato: impedisce new Singleton() dall'esterno
    private Singleton()
    {
        //codice di inizializzazione
    }

    //punto di accesso globale dall'esterno
    public static Singleton Instance
    {
        get
        {
            //primo controllo "senza lock" per performance
            if (_instance == null)
            {
                lock (_lock) //se due thread arrivano qui, uno atterra nel lock
                {
                    //secondo controllo dentro il lock per evitare doppia creazione
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    //metodo d'esempio che utilizza l'instanza singleton
    public void DoSomething()
    {
        Console.WriteLine("Metodo DoSomething chiamato sull'istanza Singleton");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Singleton s = Singleton.Instance;

        s.DoSomething();
    }
}