public class Mucca : Animale
{
    private int _quantitaLatte;

    public int QuantitaLatte
    {
        get { return _quantitaLatte;}
        set
        {
            if (value > 0)
                _quantitaLatte = value;
            else
                throw new ArgumentException("La quantità di latte prodotto non può essere negativa!");
        }
    }

    public Mucca(string Nome, int Eta, int QuantitaLatte) : base(Nome, Eta)
    {
        _quantitaLatte = QuantitaLatte;
    }

    public override string MostraInfo()
    {
        return $"Nome Mucca: {Nome} | Età Mucca: {Eta} | Quantità di latte prodotto: {QuantitaLatte} litri.";
    }

    public override void Verso()
    {
        Console.WriteLine("La mucca fa Moo!");
    }
}