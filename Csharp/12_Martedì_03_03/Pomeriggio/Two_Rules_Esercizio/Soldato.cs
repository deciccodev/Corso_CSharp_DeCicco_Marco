public class Soldato
{
    private string _nome;
    private string _grado;
    private int _anniServizio;

    public Soldato(string Nome, string Grado, int AnniServizio)
    {
        this.Nome = Nome;
        this.Grado = Grado;
        this.AnniServizio = AnniServizio;
    }

    public string Nome
    {
        get { return _nome; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nome = value;
            else
                Console.WriteLine("Nome non valido"); 
        }
    }

    public string Grado
    {
        get { return _grado; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
                _grado = value;
            else
                Console.WriteLine("Grado non valido"); 
        }
    }

    public int AnniServizio
    {
        get { return _anniServizio; }
        set 
        {
            if(value >= 0)
                _anniServizio = value;
            else
                Console.WriteLine("Anni servizio non validi");
        }
    }

    public virtual void Descrizione()
    {
        Console.Write($"Nome: {_nome}, Grado: {_grado}, Anni Servizio: {_anniServizio}, ");
    }
}