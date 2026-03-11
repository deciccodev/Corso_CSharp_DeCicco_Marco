public class DecoratoreFragola : DecoratoreTorta
{
    public DecoratoreFragola(ITorta componente) : base(componente)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " + fragole";
    }
}