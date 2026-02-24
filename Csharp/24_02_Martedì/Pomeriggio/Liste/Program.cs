using System;

class Liste
{
    public static void Main(string[] args)
    {
        List<string> parole = new List<string>();

        parole.Add("Ciao");
        parole.Add("Come");
        parole.Add("Va?");

        if (parole.Contains("Ciao")){Console.WriteLine("Parole contiene Ciao");}
        
        //STAMPA/SCORRIMENTO LISTA CON CICLO FOREACH
        foreach (string parola in parole)
        {
            Console.WriteLine(parola);
        }

        //STAMPA/SCORRIMENTO LISTA CON CICLO FOR
        for (int i = 0; i < parole.Count; i++)
        {
            Console.WriteLine($"{i} - {parole[i]}");
        }

        //MODO CORRETTO DI RIMUOVERE ITEM DA UNA LISTA
        List<string> itemsToRemove = new List<string>();

        foreach (string parola in parole)
        {
            if (parola == "Sabato"){itemsToRemove.Add(parola);}
        }

        foreach (string p in itemsToRemove)
        {
            parole.Remove(p);
        }

        //RemoveAt(index) - ELIMINA L'ELEMENTO ALL'INDEX SPECIFICATO
        parole.RemoveAt(0);

        //Clear - ELIMINA TUTTI GLI ELEMENTI DALLA LISTA
        parole.Clear();

        //RemoveRange(index1, index2) - RIMUOVE TANTI ELEMENTI QUANTI SPECIFICATO NEL SECONDO INDICE INSERITO, A PARTIRE DAL PRIMO INDICE SCRITTO
        parole.RemoveRange(0, 2);

        //Insert(index, elemento) - INSERISCE ELEMENTO AD UN INDICE SPECIFICO
        parole.Insert(1, "Gabibbo");

        //ToArray() - RESTITUISCE GLI ELEMENTI DELLA LISTA IN UN ARRAY
        string[] arrayParole = parole.ToArray();
    }
}