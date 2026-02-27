using System;

class Program
{
    static void Main(string[] args)
    {
        //instanziamento oggetto (cane)
        Cane mioCane = new Cane();

        //cambio stato dell'oggetto
        mioCane.nome = "Maya";
        mioCane.eta = 3;

        mioCane.Abbaia();
        mioCane.Descrivi();

        Cane mioCane2 = new Cane();

        mioCane2.nome = "Fido";
        mioCane2.eta = 9;

        mioCane2.Abbaia();
        mioCane2.Descrivi();

        if (ConfrontaEta(mioCane.eta, mioCane2.eta)){Console.WriteLine($"{mioCane.nome} è più vecchio di {mioCane2.nome}");}
        else{Console.WriteLine($"{mioCane2.nome} è più vecchio di {mioCane.nome}");}
    }

    public static bool ConfrontaEta(int eta1, int eta2)
    {
        return eta1 > eta2;
    }
}    

class Cane
{
    //Proprietà (stato)
    public string nome;
    public int eta;

    //Metodi (comportamento)
    public void Abbaia()
    {
        Console.WriteLine($"il cane {nome} sta abbaiando");
    }

    public void Descrivi()
    {
        Console.WriteLine($"Il cane di nome: {nome}, ha {eta} anni!");
    }
}