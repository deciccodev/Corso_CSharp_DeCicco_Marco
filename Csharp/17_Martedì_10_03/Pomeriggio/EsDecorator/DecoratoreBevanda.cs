public abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda _component;

    protected DecoratoreBevanda(IBevanda component)
    {
        _component = component;
    }

    public virtual double Costo()
    {
        return _component.Costo();
    }

    public virtual string Descrizione()
    {
        return _component.Descrizione();
    }
}