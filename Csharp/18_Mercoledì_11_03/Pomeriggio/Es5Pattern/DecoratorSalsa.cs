public class ConSalsa : IngredientiExtra //classe concreta del decoratore astratto che aggiunge un ingrediente extra al piatto base
{
    public ConSalsa(IPiatto piatto) : base(piatto) {}

    public override string Descrizione()
    {
        return _piatto.Descrizione() + " + salsa";
    }
}