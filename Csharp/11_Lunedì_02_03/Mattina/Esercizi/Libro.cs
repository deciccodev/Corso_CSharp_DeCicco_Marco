public class Libro
{
    public string titolo, autore;
    public int annoPubblicazione;

    public override string ToString()
    {
        return $"Titolo libro: {titolo}, di {autore}, Anno di Pubblicazione: {annoPubblicazione}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Libro altro)
        {
            return this.titolo == altro.titolo && this.autore == altro.autore;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(titolo, autore);
    }

    public Libro CopiaSuperficiale()
    {
        return (Libro)this.MemberwiseClone();
    }
}