public abstract class DecoratoreTorta : ITorta //classe astratta del docoratore
{
    protected ITorta _componente; //riferimento del componente base tenuto degli oggetti reali che implementano l'interfaccia ITorta

    protected DecoratoreTorta(ITorta componente)
    {
        _componente = componente;
    }

    public virtual string Descrizione()
    {
        return _componente.Descrizione();
    }
}