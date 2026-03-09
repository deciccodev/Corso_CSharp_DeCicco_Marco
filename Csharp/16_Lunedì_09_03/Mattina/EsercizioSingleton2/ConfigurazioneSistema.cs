public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema? _instanceSistema;

    private static readonly object _lock = new object();
    private Dictionary<string, string> dizionario = new Dictionary<string, string>();

    private ConfigurazioneSistema()
    {
        //codice di inizializzazione
    }

    public static ConfigurazioneSistema GetInstance()
    {
        if (_instanceSistema == null)
        {
            _instanceSistema = new ConfigurazioneSistema();
        }
        return _instanceSistema;
    }

    public void Imposta(string chiave, string valore)
    {
        dizionario[chiave] = valore;
        Console.WriteLine("configurazione aggiunta/modificata");
    }

    public void Leggi(string chiave)
    {
        foreach (var v in dizionario)
        {
            if (v.Key == chiave)
            {
                Console.WriteLine($"il valore della chiave {chiave} inserito è: {v.Value}");
            }
        }
    }

    public void StampaTutte()
    {
        Console.WriteLine($"Stampa di tutte le configurazioni presenti:");
        foreach (var v in dizionario)
        {
            Console.WriteLine($"{v.Key} - {v.Value}");
        }
    }
}
