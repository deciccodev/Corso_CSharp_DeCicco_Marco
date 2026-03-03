public class CorsoMusica : Corso
{
    public string Strumento;

    public CorsoMusica(string NomeCorso, int DurataOra, string Docente, string Strumento) : base(NomeCorso, DurataOra, Docente)
    {
        this.NomeCorso = NomeCorso;
        this.DurataOra = DurataOra;
        this.Docente = Docente;;
        this.Strumento = Strumento;
    }

    public override string ToString()
    {
        return $"Nome corso: {NomeCorso}, Ore corso: {DurataOra}, Docente corso: {Docente}, Strumento corso: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }
}