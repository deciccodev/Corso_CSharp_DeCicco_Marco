public class Pizza : IPiatto //classe concreta che rappresenta un piatto base, viene creato dalla factory PiattoFactory
{
    public string Descrizione()
    {
        return "Pizza";
    }
}

public class Hamburger : IPiatto //classe concreta che rappresenta un piatto base, viene creato dalla factory PiattoFactory
{
    public string Descrizione()
    {
        return "Hamburger";
    }
}

public class Insalata : IPiatto //classe concreta che rappresenta un piatto base, viene creato dalla factory PiattoFactory
{
    public string Descrizione()
    {
        return "Insalata";
    }
}