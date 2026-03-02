public class Veicolo
{
    protected string marca, modello;

    public Veicolo(string marca, string modello)
    {
        this.marca = marca;
        this.modello = modello;
    }


    public virtual void StampaInfo()
    {
        Console.Write($"Marca {marca}, Modello {modello} ");
    }
}