public class Utente 
{
    private string _nome;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nome = value;
        }
    }

    public Utente(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome Utente: {Nome}";
    }
}