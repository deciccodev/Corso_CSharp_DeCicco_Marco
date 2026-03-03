public class Auto : Veicolo
{
    public Auto(string Targa) : base(Targa)
    {
    }

    public override void Ripara()
    {
        Console.WriteLine($"Targa: {Targa} - Controllo olio, freni e motore dell'auto.");
    }
}