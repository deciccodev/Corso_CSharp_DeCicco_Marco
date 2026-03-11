public class Pizza : IPiatto //classe concreta che rappresenta un piatto base, viene creato dalla factory PiattoFactory
{
    public string Descrizione()
    {
        return "Pizza";
    }
}