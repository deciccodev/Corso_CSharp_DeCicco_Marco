public abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda _component;

    protected DecoratoreBevanda(IBevanda component)
    {
        _component = component;
    }

    public virtual double Costo()
    {
        throw new NotImplementedException();
    }

    public virtual string Descrizione()
    {
        throw new NotImplementedException();
    }
}