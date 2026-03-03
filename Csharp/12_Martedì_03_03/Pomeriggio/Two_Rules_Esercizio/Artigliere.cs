public class Artigliere : Soldato
{
    private int _calibro;

    public int Calibro
    {
        get{ return _calibro; }
        set 
        {
            if (value > 0)
                _calibro = value;
            else
                Console.WriteLine("Calibro non valido"); 
        }
    }

    public Artigliere(string Nome, string Grado, int AnniServizio, int Calibro) : base(Nome, Grado, AnniServizio)
    {
        this.Nome = Nome;
        this.Grado = Grado;
        this.AnniServizio = AnniServizio;
        this.Calibro = Calibro;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.Write($"Calibro: {_calibro}");
    }
}