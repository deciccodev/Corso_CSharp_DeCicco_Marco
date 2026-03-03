public class Corso
{
    public string NomeCorso;
    public int DurataOra;
    public string Docente;
    public List<string> Studenti;

    public Corso(string NomeCorso, int DurataOra, string Docente)
    {
        this.NomeCorso = NomeCorso;
        this.DurataOra = DurataOra;
        this.Docente = Docente;
        Studenti = new List<string>();
    }

    public void AggiungiStudente(string nomeStudente)
    {
        if (!Studenti.Contains(nomeStudente))
        {
            Studenti.Add(nomeStudente);
            Console.WriteLine("Studente aggiunto correttamente!");
        }
        else
        {
            Console.WriteLine("Lo studente è già iscritto al corso.");
        }
    }

    public override string ToString()
    {
        return $"Nome corso: {NomeCorso}, durata ore: {DurataOra}, docente: {Docente}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("messaggio generico classe padre");
    }
}