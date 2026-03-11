public class Insalata : IPiatto //classe concreta che rappresenta un piatto base, viene creato dalla factory PiattoFactory
{
    public string Descrizione()
    {
        return "Insalata";
    }
}