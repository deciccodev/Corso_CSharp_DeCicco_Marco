public class DecoratorePanna : DecoratoreTorta //classe concreta del decoratore panna
{
    public DecoratorePanna(ITorta componente) : base(componente)
    {
    }

    //implementazione del metodo virtual della classe astratta decoratore
    public override string Descrizione()
    {
        return base.Descrizione() + " + panna"; 
    }
}