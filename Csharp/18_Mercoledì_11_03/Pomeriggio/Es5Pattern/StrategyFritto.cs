public class StrategyFritto : IPreparazioneStategia //classe concreta dell'interfaccia IPreparazioneStategia, definisce 
                                                    // uno specifico metodo di preparazione del piatto
{
    public string Prepara(string descrizione)
    {
        return "Fritto in olio";
    }
}