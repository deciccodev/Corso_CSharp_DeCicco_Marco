public class Caffe : IBevanda
{
    public double _costo = 1.00d;
    public string _descrizione = "Caffè base";

    public double Costo()
    {
        return _costo;
    }

    public string Descrizione()
    {
        return _descrizione;
    }
}