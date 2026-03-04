public class OperatoreLogistica : Operatore
{
    private int _numeroConsegne;

    public int NumeroConsegne
    {
        get { return _numeroConsegne;}
        set
        {
            if(value >= 0)
            {
                _numeroConsegne = value;
            }
        }
    }
    
    
    public OperatoreLogistica(string Nome, string Turno, int NumeroConsegne) : base(Nome, Turno)
    {
        this.NumeroConsegne = NumeroConsegne;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {_numeroConsegne} consegne");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Tipo: {GetType().Name}, Turno: {Turno}";
    }
}