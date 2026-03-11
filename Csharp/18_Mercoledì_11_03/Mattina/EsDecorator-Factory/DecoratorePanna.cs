public class DecoratorePanna : DecoratoreTorta
{
    public DecoratorePanna(ITorta componente) : base(componente)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " + panna"; 
    }
}