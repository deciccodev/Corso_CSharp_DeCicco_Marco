public abstract class Corso
{
    private string _titolo;
    private int _durataOre;
    private Docente _docente;

    public string Titolo
    {
        get { return _titolo;}
        set
        {
            if(!string.IsNullOrEmpty(value))
                _titolo = value;
            else
                Console.WriteLine("Titolo corso non valido!");
        }
    }

    public int DurataOre
    {
        get { return _durataOre;}
        set
        {
            if(value > 0)
                _durataOre = value;
            else
                Console.WriteLine("Ore corso non valide!");
        }
    }

    public Docente Docente
    {
        get { return _docente;}
        set
        {
            if(value != null)
                _docente = value;
        }
    }

    public Corso(string Titolo, int DurataOre, Docente Docente)
    {
        this.Titolo = Titolo;
        this.DurataOre = DurataOre;
        this.Docente = Docente;
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}