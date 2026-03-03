public class CorsoPittura : Corso
{
    public string Tecnica;

    public CorsoPittura(string NomeCorso, int DurataOra, string Docente, string Tecnica) : base(NomeCorso, DurataOra, Docente)
    {
        this.NomeCorso = NomeCorso;
        this.DurataOra = DurataOra;
        this.Docente = Docente;
        this.Tecnica = Tecnica;
    }

    public override string ToString()
    {
        return $"Nome corso: {NomeCorso}, Ore corso: {DurataOra}, Docente corso: {Docente}, Tecnica corso: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
    }
}