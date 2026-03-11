public class StrategiaSomma : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }

    public string Descrizione()
    {
        return "Somma";
    }
}