public sealed class RegistroVeicoli
{
    private static RegistroVeicoli _instance;

    private List<IVeicolo> _veicoliCreati = new List<IVeicolo>();

    private RegistroVeicoli(){}

    public static RegistroVeicoli GetInstance()
    {
        if (_instance == null)
        {
            _instance = new RegistroVeicoli();
        }
        return _instance;
    }

    public void Registra(IVeicolo veicolo)
    {
        _veicoliCreati.Add(veicolo);
        Console.WriteLine($"Veicolo aggiunto alla lista!");
    }

    public void StampaVeicoli()
    {
        Console.WriteLine($"Stampa di tutti i veicoli presenti:");
        foreach (var v in _veicoliCreati)
        {
            Console.WriteLine($"{v}");
        }
    }
}
