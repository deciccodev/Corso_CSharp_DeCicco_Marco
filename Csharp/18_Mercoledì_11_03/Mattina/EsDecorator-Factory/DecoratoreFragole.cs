public class DecoratoreFragola : DecoratoreTorta //classe concreta del decoratore fragole
{
    public DecoratoreFragola(ITorta componente) : base(componente)
    {
    }

    //implementazione del metodo virtual della classe astratta decoratore
    public override string Descrizione()
    {
        return base.Descrizione() + " + fragole";
    }
}