public class VoloAereo
{
    private const int MAX_POSTI = 150;
    private int _postiOccupati = 0;

    public string CodiceVolo { get; set; }

    public int PostiOccupati
    {
        get { return _postiOccupati; }
    }

    public int PostiLiberi
    {
        get { return MAX_POSTI - _postiOccupati; }
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= PostiLiberi)
        {
            _postiOccupati += numeroPosti;
            Console.WriteLine($"Prenotazione effettuata! Posti ancora disponibili: {PostiLiberi}");
        }
        else
        {
            Console.WriteLine($"Prenotazione non possibile. Posti liberi: {PostiLiberi}");
        }
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= _postiOccupati)
        {
            _postiOccupati -= numeroPosti;
            Console.WriteLine($"Prenotazione annullata! Posti ancora disponibili: {PostiLiberi}");
        }
        else
        {
            Console.WriteLine($"Annullamento non valido. Posti occupati: {PostiOccupati}");
        }
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"Codice volo: {CodiceVolo} | Posti occupati: {PostiOccupati} | Posti liberi: {PostiLiberi}");
    }
}