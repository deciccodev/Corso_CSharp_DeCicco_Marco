public class Docente
{
    private string _nome;
    private string _materiaInsegnata;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrEmpty(value)){ _nome = value;}
            else{Console.WriteLine("Errore nome docente!");}
        }
    }
    public string MateriaInsegnata
    {
        get { return _materiaInsegnata; }
        set
        {
            if (!string.IsNullOrEmpty(value)){ _materiaInsegnata = value;}
            else{Console.WriteLine("Errore materia insegnata docente!");}
        }
    }

    public Docente(string Nome, string MateriaInsegnata)
    {
        this.Nome = Nome;
        this.MateriaInsegnata = MateriaInsegnata;
    }
}