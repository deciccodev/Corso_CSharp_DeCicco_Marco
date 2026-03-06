public abstract class Animale
{
    private string _nome;
    private int _eta;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if(!string.IsNullOrEmpty(value))
                _nome = value;
            else
                throw new ArgumentException("Nome inserito non valido");
        }
    }

    public int Eta
    {
        get { return _eta; }
        set
        {
            if (value > 0)
                _eta = value;
            else
                throw new ArgumentException("Età inserita non valida");
        }
    }

    public Animale(string Nome, int Eta)
    {
        _nome = Nome;
        _eta = Eta;
    }

    //Dichiaro i metodi abstract così che le classi che ereditano animale sono costrette ad implementare i metodi
    public abstract void Verso();
    public abstract string MostraInfo();
}