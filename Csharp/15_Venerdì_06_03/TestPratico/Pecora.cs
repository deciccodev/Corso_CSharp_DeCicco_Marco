public class Pecora : Animale
{
    private int _quantitaLana;

    public int QuantitaLana
    {
        get { return _quantitaLana;}
        set
        {
            if (value > 0)
                _quantitaLana = value;
            else
                throw new ArgumentException("La quantità di lana prodotta non può essere negativa!");
        }
    }

    public Pecora(string Nome, int Eta, int QuantitaLana) : base(Nome, Eta)
    {
        _quantitaLana = QuantitaLana;
    }

    public override string MostraInfo()
    {
        return $"Nome Pecora: {Nome} | Età Pecora: {Eta} | Quantità di lana prodotta: {QuantitaLana} Kg.";
    }

    public override void Verso()
    {
        Console.WriteLine("La pecora fa Bèèèè!");
    }
}