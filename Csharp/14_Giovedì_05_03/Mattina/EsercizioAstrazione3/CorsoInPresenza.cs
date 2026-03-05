public class CorsoInPresenza : Corso
{
    private string _aula;
    private int _numeroPosti;

    public string Aula
    {
        get { return _aula; }
        set
        {
            if (!string.IsNullOrEmpty(value)){ _aula = value;}
            else{Console.WriteLine("Aula non valida!");}
        }
    }

    public int NumeroPosti
    {
        get { return _numeroPosti;}
        set
        {
            if(value > 0){_numeroPosti = value;}
            else{Console.WriteLine("Numero posti non validi!");}
        }
    }
    
    public CorsoInPresenza(string Titolo, int DurataOre, Docente Docente, string Aula, int NumeroPosti) : base(Titolo, DurataOre, Docente)
    {
        this.Aula = Aula;
        this.NumeroPosti = NumeroPosti;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Tipo corso: {GetType().Name}");
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"Titolo corso: {Titolo}, Durata corso: {DurataOre} ore, Aula svolgimento corso: {Aula}, Numero di posti disponibili nel corso: {NumeroPosti}");
    }
}