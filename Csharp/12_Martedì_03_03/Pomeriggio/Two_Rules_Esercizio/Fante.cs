public class Fante : Soldato
{
    private string _arma;

    public string Arma
    {
        get{ return _arma; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
                _arma = value;
            else
                Console.WriteLine("Arma non valido"); 
        }
    }

    public Fante(string Nome, string Grado, int AnniServizio, string Arma) : base(Nome, Grado, AnniServizio)
    {
        this.Nome = Nome;
        this.Grado = Grado;
        this.AnniServizio = AnniServizio;
        this.Arma = Arma;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.Write($"Arma: {_arma}");
    }
}