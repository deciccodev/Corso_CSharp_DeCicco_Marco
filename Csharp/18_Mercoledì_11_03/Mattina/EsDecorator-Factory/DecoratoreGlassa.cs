public class DecoratoreGlassa : DecoratoreTorta //classe concreta del decoratore glassa
{
    public DecoratoreGlassa(ITorta componente) : base(componente)
    {
    }

    //implementazione del metodo virtual della classe astratta decoratore
    public override string Descrizione()
    {
        return base.Descrizione() + " + glassa";
    }
}