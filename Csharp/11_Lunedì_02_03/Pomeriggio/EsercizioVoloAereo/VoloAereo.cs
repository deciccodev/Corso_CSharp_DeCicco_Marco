public class VoloAereo
{
    const int MAX_POSTI = 150;
    public string codiceVolo;
    private int _postiOccupati = 0, _postiLiberi = 140;

    public int PostiOccupati
    {
        get { return _postiOccupati; }
        set {if (_postiOccupati < 140) _postiOccupati = MAX_POSTI - PostiLiberi;}
    }

    public int PostiLiberi
    {
        get { return _postiLiberi; }
        set {if (_postiLiberi >= 140) _postiLiberi = MAX_POSTI - PostiOccupati;}
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (numeroPosti < _postiOccupati)
        {
            PostiOccupati+= numeroPosti;
            PostiLiberi-= numeroPosti;
            Console.WriteLine($"Prenotazione effettuata con successo! posti ancora disponibili: {PostiLiberi}");
        }
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        PostiOccupati-= numeroPosti;
        PostiLiberi+= numeroPosti;
        Console.WriteLine($"Prenotazione annullata con successo! posti ancora disponibili: {PostiLiberi}");
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"Codice volo: {codiceVolo}, posti occupati: {PostiOccupati}, posti liberi: {PostiLiberi}");
    }
}