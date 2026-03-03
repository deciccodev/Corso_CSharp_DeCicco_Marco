public class CorsoDanza : Corso
{
    public string Stile;

    public CorsoDanza(string NomeCorso, int DurataOra, string Docente, string Stile) : base(NomeCorso, DurataOra, Docente)
    {
        this.NomeCorso = NomeCorso;
        this.DurataOra = DurataOra;
        this.Docente = Docente;
        this.Stile = Stile;
    }

    public override string ToString()
    {
        return $"Nome corso: {NomeCorso}, Ore corso: {DurataOra}, Docente corso: {Docente}, Stile corso: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}