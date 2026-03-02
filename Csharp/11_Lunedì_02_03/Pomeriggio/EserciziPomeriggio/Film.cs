public class Film
{
    public string titolo, regista, genere;
    public int anno;

    public Film(string titolo, string regista, int anno, string genere)
    {
        this.titolo = titolo;
        this.regista = regista;
        this.anno = anno;
        this.genere = genere;
    }
    
    public override string ToString()
    {
        return $"Titolo Film: {titolo}, Regista: {regista}, Anno: {anno}, Genere: {genere}\n";
    }
}