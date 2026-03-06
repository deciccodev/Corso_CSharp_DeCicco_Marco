public class Gallina : Animale
{
    private int _uovaProdotte;

    public int UovaProdotte
    {
        get { return _uovaProdotte;}
        set
        {
            if (value > 0)
                _uovaProdotte = value;
            else
                throw new ArgumentException("La quantità di uova prodotte non può essere negativa!");
        }
    }

    public Gallina(string Nome, int Eta, int UovaProdotte) : base(Nome, Eta)
    {
        _uovaProdotte = UovaProdotte;
    }

    public override string MostraInfo()
    {
        return $"Nome Gallina: {Nome} | Età Gallina: {Eta} | Quantità di uova prodotte: {UovaProdotte}.";
    }

    public override void Verso()
    {
        Console.WriteLine("La gallina fa Chiccirichììì!");
    }
}