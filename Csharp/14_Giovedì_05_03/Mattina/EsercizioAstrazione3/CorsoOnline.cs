public class CorsoOnline : Corso
{
    private string _piattaforma;
    private string _linkAccesso;

    public string Piattaforma
    {
        get { return _piattaforma; }
        set
        {
            if (!string.IsNullOrEmpty(value)){ _piattaforma = value;}
            else{Console.WriteLine("Piattaforma non valida!");}
        }
    }

    public string LinkAccesso
    {
        get { return _linkAccesso; }
        set
        {
            if (!string.IsNullOrEmpty(value)){ _linkAccesso = value;}
            else{Console.WriteLine("Link di accesso non valido!");}
        }
    }
    
    public CorsoOnline(string Titolo, int DurataOre, Docente Docente, string Piattaforma, string LinkAccesso) : base(Titolo, DurataOre, Docente)
    {
        this.Piattaforma = Piattaforma;
        this.LinkAccesso = LinkAccesso;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Tipo corso: {GetType().Name}");
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"Titolo corso: {Titolo}, Durata corso: {DurataOre} ore, Piattaforma svolgimento corso: {Piattaforma}, Link di accesso per il corso: {LinkAccesso}");
    }
}