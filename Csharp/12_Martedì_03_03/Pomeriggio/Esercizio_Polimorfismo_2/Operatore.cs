public class Operatore
{
    private string _nome;
    private string _turno;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _nome = value;
            }
        }
    }

    public string Turno
    {
        get { return _turno; }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _turno = value;
            }
        }
    }

    public Operatore(string Nome, string Turno)
    {
        this.Nome = Nome;
        this.Turno = Turno;
    }

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Operatore generico in servizio.");
    }

    public virtual string ToString()
    {
        return $"Placeholder";
    }
}