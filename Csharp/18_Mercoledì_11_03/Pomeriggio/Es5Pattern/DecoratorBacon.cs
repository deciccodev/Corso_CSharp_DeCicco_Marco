public class ConBacon : IngredientiExtra //classe concreta del decoratore astratto che aggiunge un ingrediente extra al piatto base
{
    public ConBacon(IPiatto piatto) : base(piatto) {}

    public override string Descrizione()
    {
        return _piatto.Descrizione() + " + bacon";
    }
}