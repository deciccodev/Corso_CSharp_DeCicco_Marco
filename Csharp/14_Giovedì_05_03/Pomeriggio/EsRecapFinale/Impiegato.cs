public class Impiegato : Persona
{
    private Ruoli _ruolo;

    public Ruoli Ruolo
    {
        get { return _ruolo;}
    }
    
    public Impiegato(string Nome, string Cognome, Badge Badge, Ruoli Ruolo) : base(Nome, Cognome, Badge)
    {
        _ruolo = Ruolo;
    }

    public override Ruoli ControllaRuolo()
    {
        return _ruolo;
    }

}