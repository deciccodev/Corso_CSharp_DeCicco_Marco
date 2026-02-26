using System;

class Dictionary
{
    public Dictionary()
    {
        Dictionary<int, string> studenti = new Dictionary<int, string>();

        //Dichiarazione con inizializzazione
        Dictionary<string, string> capitali = new Dictionary<string, string>()
        {
            {"Italia", "Roma"},
            {"Francia", "Parigi"},
            {"Spagna", "Madrid"},
        };

        //Aggiungere elemento
        studenti.Add(1, "Mario");
        studenti[2] = "Luigi"; //in questo caso il 2 nelle parentesi è la chiave
        
        //Accedere ad un valore
        Console.WriteLine(studenti[1]);

        //Verificare esistenza valore
        studenti.ContainsKey(1);
        studenti.ContainsValue("Luigi");

        //Rimuovere valore
        studenti.Remove(2);

        //Accesso con indice sequenziale
        Console.WriteLine($"{studenti.ElementAt(1)}");

        //Iterazione
        foreach (var item in studenti)
        {
            Console.WriteLine($"ID Studente: {item.Key}, Nome {item.Value}");
        }
    }
}