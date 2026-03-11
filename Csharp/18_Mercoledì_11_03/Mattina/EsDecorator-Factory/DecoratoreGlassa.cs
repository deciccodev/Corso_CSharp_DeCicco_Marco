public class DecoratoreGlassa : DecoratoreTorta
{
    public DecoratoreGlassa(ITorta componente) : base(componente)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " + glassa";
    }
}