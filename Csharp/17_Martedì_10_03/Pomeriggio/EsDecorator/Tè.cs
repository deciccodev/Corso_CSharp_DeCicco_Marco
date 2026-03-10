public class Te : IBevanda
{
    public double _costo = 1.50d;
    public string _descrizione = "Tè base";

    public double Costo()
    {
        return _costo;
    }

    public string Descrizione()
    {
        return _descrizione;
    }
}