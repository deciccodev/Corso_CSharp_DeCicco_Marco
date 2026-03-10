public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema? _instance;

    private static readonly object _lock = new object();
    private Dictionary<string, string> configurazioni = new Dictionary<string, string>();

    private ConfigurazioneSistema()
    {
        //codice di inizializzazione
    }

    public static ConfigurazioneSistema Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurazioneSistema();
            }
            return _instance;
        }
    }

    public void Imposta(string chiave, string valore)
    {
        configurazioni[chiave] = valore;
    }

    public string Leggi(string chiave)
    {
        if (configurazioni.TryGetValue(chiave, out string valore))
        {
            Console.WriteLine($"Il valore della chiave {chiave} è: {valore}");
            return valore;
        }
        else
        {
            Console.WriteLine($"Non esiste la chiave: {chiave}");
            return null;
        }
        }

    public void StampaTutte()
    {
        if (configurazioni.Count == 0){Console.WriteLine("Non sono presenti configurazioni!");}
        else
        {
            Console.WriteLine($"Stampa di tutte le configurazioni presenti:");
            foreach (var v in configurazioni)
            {
                Console.WriteLine($"{v.Key} - {v.Value}");
            }
        }
    }
}
