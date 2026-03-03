public class Camion : Veicolo
{
    public Camion(string Targa) : base(Targa)
    {
    }

    public override void Ripara()
    {
        Console.WriteLine($"Targa: {Targa} - Controllo sospensioni, freni rinforzati e carico del camion.");
    }
}