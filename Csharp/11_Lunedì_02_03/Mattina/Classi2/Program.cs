using System;
using System.Security.Cryptography.X509Certificates;


public class Punto
{
    public int X, Y;

    public override bool Equals(object obj)
    {
        if (obj is Punto altro)
        {
            return this.X == altro.X && this.Y == altro.Y;
        }
        return false;
    }
}


public class Prodotto
{
    public string Nome;
    public double Prezzo;

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Prezzo);
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Punto a = new Punto{X = 1, Y = 2};
        Punto b = new Punto{X = 1, Y = 2};

        Console.WriteLine(a.Equals(b));
    }
}


