public interface IPiatto //l'interfaccia che definisce il comportamento dei piatti base concreti che la estendono
{
    string Descrizione();
}

public interface IPreparazioneStategia //interfaccia delle strategie per i metodi di preparazione dei piatti
{
    string Prepara(string Descrizione);
}

public interface IObserver //interfaccia osservatore che definisce il comportamento che le classi concrete avranno
{
    void Update(string messaggio);
}