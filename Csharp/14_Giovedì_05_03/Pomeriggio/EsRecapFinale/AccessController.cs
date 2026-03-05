public class AccessController
{
    private Log _log;

    public AccessController(Log Log)
    {
        _log = Log;
    }

    public void Entrata(Persona persona)
    {
        if (!persona.Badge.IsActive)
        {
            _log.AggiungiLog(persona, "ACCESSO NEGATO (Badge disattivo)");
            return;
        }

        int codice = persona.Badge.CodiceBadge;
        Ruoli ruolo = persona.ControllaRuolo();

        bool accessoConsentito = false;

        if (ruolo == Ruoli.Dipendente && codice >= 1000 && codice < 2000)
            accessoConsentito = true;

        if (ruolo == Ruoli.Manager && codice >= 2000 && codice < 3000)
            accessoConsentito = true;

        if (ruolo == Ruoli.Amministratore && codice >= 3000 && codice < 4000)
            accessoConsentito = true;

        if (accessoConsentito)
            _log.AggiungiLog(persona, "ENTRATA CONSENTITA");
        else
            _log.AggiungiLog(persona, "ACCESSO NEGATO (Range badge errato)");
    }

    public void Uscita(Persona persona)
    {
        _log.AggiungiLog(persona, "USCITA");
    }

    public void Registrazione(Persona persona)
    {
        _log.AggiungiLog(persona, "IMPIEGATO REGISTRATO");
    }

    public void MostraLog()
    {
        _log.MostraLog();
    }
}