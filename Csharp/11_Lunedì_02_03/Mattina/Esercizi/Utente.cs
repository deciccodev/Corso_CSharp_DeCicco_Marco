class Utente
{
    public string nome;
    public int credito;
    public Macchina macchina;

    public Utente(string nome, int credito)
    {
        this.nome = nome;
        this.credito = credito;
        this.macchina = new Macchina();
    }

    public override string ToString()
    {
        return $"Nome Utente: {nome} \nCaratteristiche Macchina: {macchina}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Utente altro)
        {
            return this.nome == altro.nome && this.credito == altro.credito && this.macchina.Equals(altro.macchina);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(nome, credito, macchina);
    }
}