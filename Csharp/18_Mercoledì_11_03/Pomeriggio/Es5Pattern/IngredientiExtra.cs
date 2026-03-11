public abstract class IngredientiExtra : IPiatto //classe astratta con riferimento all'oggetto IPiatto da decorare 
{
    protected IPiatto _piatto;

    public IngredientiExtra(IPiatto piatto)
    {
        _piatto = piatto;
    }
    public abstract string Descrizione();
}