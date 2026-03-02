using System;
using System.Diagnostics;

public class Distruttore
{
    Stopwatch sw;

    public Distruttore()
    {
        sw = Stopwatch.StartNew();
        Console.WriteLine("Ogetto Instanziato");
    }

    public void ShowDuration()
    {
        Console.WriteLine("Questa istanza di {0} è stata in esistenza per {1}",
                        this, sw.Elapsed);
    }

    ~Distruttore()
    {
        Console.WriteLine("Finilizzazione Oggetto");
        sw.Stop();
        Console.WriteLine("Questa istanza di {0} è stata in esistenza per {1}",
                        this, sw.Elapsed);
    }
}