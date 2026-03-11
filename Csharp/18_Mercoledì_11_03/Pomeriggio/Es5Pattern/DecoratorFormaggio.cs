public class ConFormaggio : IngredientiExtra //classe concreta del decoratore astratto che aggiunge un ingrediente extra al piatto base
{
    public ConFormaggio(IPiatto piatto) : base(piatto) {}

    public override string Descrizione()
    {
        return _piatto.Descrizione() + " + formaggio";
    }
}