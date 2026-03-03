public class Veicolo
{
    private string _targa;

    public string Targa
    {
        get { return _targa; }
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
                _targa = value;
        }
    }

    public Veicolo(string Targa)
    {
        this.Targa = Targa;
    }

    public virtual void Ripara()
    {
        Console.WriteLine("Il veicolo viene controllato.");
    }
}