public class Auto : Veicolo
{
    public int numeroPorte;

    public Auto(int numeroPorte) : base(marca, modello)
    {
        this.numeroPorte = numeroPorte;
    }
    
    public override void StampaInfo()
    {
        Console.Write($"L'oggetto è una auto di ");
        base.StampaInfo();
        Console.Write($"e possiede {numeroPorte} porte.\n");
    }
}