public abstract class DecoratoreTorta : ITorta
{
    protected ITorta _componente;

    protected DecoratoreTorta(ITorta componente)
    {
        _componente = componente;
    }

    public virtual string Descrizione()
    {
        return _componente.Descrizione();
    }
}