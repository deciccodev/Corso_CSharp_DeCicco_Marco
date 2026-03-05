public abstract class Persona
{
    private string _nome;
    private string _cognome;
    private Badge _badge;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Nome non valido");
            
            _nome = value;
        }
    }

    public string Cognome
    {
        get { return _cognome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Cognome non valido");
            
            _cognome = value;
        }
    }

    public Badge Badge
    {
        get { return _badge; }
    }

    public Persona(string Nome, string Cognome, Badge Badge)
    {
        this.Nome = Nome;
        this.Cognome = Cognome;
        _badge = Badge;
    }

    public abstract Ruoli ControllaRuolo();
}