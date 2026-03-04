public class OperatoreEmergenza : Operatore
{
    private int _livelloUrgenza;

    public int LivelloUrgenza
    {
        get { return _livelloUrgenza;}
        set
        {
            if(value >= 1 && value <= 5)
            {
                _livelloUrgenza = value;
            }
        }
    }
    
    
    public OperatoreEmergenza(string Nome, string Turno, int LivelloUrgenza) : base(Nome, Turno)
    {
        this.LivelloUrgenza = LivelloUrgenza;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {_livelloUrgenza}");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Tipo: {GetType().Name}, Turno: {Turno}";
    }
}