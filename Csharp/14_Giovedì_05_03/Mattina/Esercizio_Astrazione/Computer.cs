public class Computer : DispositivoElettronico
{
    public Computer(string Modello) : base(Modello)
    {
    }

    public override void Accendi()
    {
        Console.WriteLine("Il computer si avvia...");
    }

    public override void Spegni()
    {
        Console.WriteLine("Il computer si spegne.");
    }

    public override void MostraInfo()
    {
        Console.WriteLine($"Sono un computer modello: {Modello}");
    }
}