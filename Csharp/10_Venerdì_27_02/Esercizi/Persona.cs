class Persona
{
    public string? nome;
    public string? cognome;
    public int annoNascita, eta;

    /*public Persona(string nome, string cognome, int annoNascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.annoNascita = annoNascita;
    }*/

    public override string ToString()
    {
        return $"Nome: {nome}, Età: {eta}";
    }
}