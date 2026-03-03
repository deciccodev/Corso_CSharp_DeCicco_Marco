public class Moto : Veicolo
{
    public Moto(string Targa) : base(Targa)
    {
    }

    public override void Ripara()
    {
        Console.WriteLine($"Targa: {Targa} - Controllo catena, freni e gomme della moto.");
    }
}