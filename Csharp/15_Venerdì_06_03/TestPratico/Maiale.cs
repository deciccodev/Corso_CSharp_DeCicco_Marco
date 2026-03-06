public class Maiale : Animale
{
    private int _peso;

    public int Peso
    {
        get { return _peso;}
        set
        {
            if (value > 0)
                _peso = value;
            else
                throw new ArgumentException("Il peso del maiale non può essere negativo!");
        }
    }

    public Maiale(string Nome, int Eta, int Peso) : base(Nome, Eta)
    {
        _peso = Peso;
    }

    public override string MostraInfo()
    {
        return $"Nome Maiale: {Nome} | Età Maiale: {Eta} | Peso del Maiale: {Peso} Kg.";
    }

    public override void Verso()
    {
        Console.WriteLine("La maiale fa Oink!");
    }
}