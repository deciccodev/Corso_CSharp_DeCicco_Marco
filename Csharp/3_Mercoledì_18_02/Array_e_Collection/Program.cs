using System;

class Array_eCollection
{
    public static void Main()
    {   
        //Creazione array di 5 elementi
        /*int[] voti = new int[5];

        //Inserimento voti da tastiera
        for (int i = 0; i < voti.Length; i++)
        {
            Console.Write($"Inserisci il voto {i + 1}");
            voti[i] = int.Parse(Console.ReadLine());
        }

        //calcolo media
        int somma = 0;
        for (int i = 0; i < voti.Length; i++)
        {
            somma += voti[i];
        }

        float media = (float)somma / voti.Length;
        Console.WriteLine($"La media dei voti è: {media}");

        //STRUTTURA FOREACH
        string parola = "CSharp";

        Console.WriteLine("Caratteri della stringa");
        foreach (char carattere in parola)
        {
            Console.WriteLine(carattere);
        }

        //STAMPA CON FOREACH DI ARRAY DI NUMERI
        int[] numeri = new int[3];

        for (int i = 0; i < numeri.Length; i++)
        {
            Console.Write($"Inserisci il numumero {i + 1}: ");
            numeri[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numeri dell'Array:");
        foreach (int numero in numeri)
        {
            Console.Write($"{numero}, ");
        }*/


        //esempi manipolazioni stringhe
        char simbolo = 'A';
        Console.WriteLine($"valore simbolo: {char.GetNumericValue(simbolo)}");

        string nome = "Marco";
        nome = nome.ToUpper();
        Console.WriteLine(nome);
        Console.WriteLine(nome.Contains(simbolo));
    }
}