//Extra: creare la classe esercito che è composta da X oggetti fante o artigliere e li può stampare tutti coi loro dettagli
public class Esercito : Soldato
{
    public Esercito(string Nome, string Grado, int AnniServizio) : base(Nome, Grado, AnniServizio)
    {
    }

    public void StampaDettagli(List<Soldato> lista)
    {
        foreach (var l in lista)
        {
            l.Descrizione();
            Console.WriteLine();
        }
    }
}