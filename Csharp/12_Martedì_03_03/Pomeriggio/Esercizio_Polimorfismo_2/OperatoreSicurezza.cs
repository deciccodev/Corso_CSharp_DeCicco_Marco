public class OperatoreSicurezza : Operatore
{
    private string _areaSorvegliata;

    public string AreaSorvegliata
    {
        get { return _areaSorvegliata;}
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _areaSorvegliata = value;
            }
        }
    }
    
    
    public OperatoreSicurezza(string Nome, string Turno, string AreaSorvegliata) : base(Nome, Turno)
    {
        this.AreaSorvegliata = AreaSorvegliata;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {_areaSorvegliata}");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Tipo: {GetType().Name}, Turno: {Turno}";
    }
}