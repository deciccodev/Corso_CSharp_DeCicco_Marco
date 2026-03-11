public class Calcolatrice
{
    private IStrategiaOperazione _strategiaOperazione;

    public double EseguiOperazione(double a, double b)
    {
        return _strategiaOperazione.Calcola(a, b);
    }

    public void ImpostaStrategia(IStrategiaOperazione nuovaStrategia)
    {
        _strategiaOperazione = nuovaStrategia;
    }

    public string Descrizione()
    {
        return _strategiaOperazione.Descrizione();
    }
}