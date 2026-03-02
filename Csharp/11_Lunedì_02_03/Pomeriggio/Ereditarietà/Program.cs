//Classe base
public class Animale
{
    protected int eta;

    public virtual void Verso() // i metodi virtual possono essere overridati nelle classi ereditate dalla base
    {
        Console.WriteLine("L'animale emette un verso");
    }

    public void Mangia()
    {
        Console.WriteLine("L'animale mangia");
    }
}

public class Elefante : Animale
{
    public void ImpostaEta(int nuovaEta)
    {
        eta = nuovaEta;  //Accesso ad eta consentito grazie a protected
    }
}

//Classe derivata
public class Cane : Animale
{
    //Metodo specifico della classe derivata
    public void Scodinzola()
    {
        Console.WriteLine("Il cane scodinzola");
    }

    public override void Verso()
    {
        base.Verso();
        Console.WriteLine("Il cane abbaia");
    }

    public new void Mangia()
    {
        Console.WriteLine("Il cane mangia i croccantini");
    }
}

//Programma principale
public class Program
{
    public static void Main(string[] args)
    {
        Cane mioCane = new Cane();
        mioCane.Verso();
        mioCane.Scodinzola();
    }
}