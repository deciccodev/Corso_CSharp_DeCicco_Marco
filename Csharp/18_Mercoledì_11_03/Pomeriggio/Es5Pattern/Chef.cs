public class Chef //classe context dello strategy pattern
{
    private IPreparazioneStategia _strategiaCottura; //riferimento alla strategia di preparazione 

    public string PrepaPiatto(IPiatto piatto)
    {
        return _strategiaCottura.Prepara(piatto.Descrizione());
    }

    public Chef(IPreparazioneStategia nuovaStrategia)
    {
        _strategiaCottura = nuovaStrategia;
    }
}