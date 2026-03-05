public class Stampante : DispositivoElettronico
{
    public Stampante(string Modello) : base(Modello)
    {
    }

    public override void Accendi()
    {
        Console.WriteLine("La stampante si accende.");
    }

    public override void Spegni()
    {
        Console.WriteLine("La stampante va in standby");
    }

    public override void MostraInfo()
    {
        Console.WriteLine($"Sono una stampante modello: {Modello}");
    }
}