public class Moto : Veicolo
{
    public string tipoManubrio;

    public Moto(string marca, string modello, string tipoManubrio)
    {
        this.marca = marca;
        this.modello = modello;
        this.tipoManubrio = tipoManubrio;
    }

    public override void StampaInfo()
    {
        Console.Write($"L'oggetto è una moto di ");
        base.StampaInfo();
        Console.Write($"e possiede un manubrio di tipo: {tipoManubrio}.\n");
    }
}