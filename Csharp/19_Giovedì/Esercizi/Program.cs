using System;

class Esercizi
{
    public static void Main(string[] args)
    {
        Console.Write("Come ti chiami?: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci saluto: ");
        string saluto = Console.ReadLine();

        Console.Write("Inserisci un numero intero: ");
        int numeroIntero = int.Parse(Console.ReadLine());

        Console.Write("Inserisci base numero per la potenza: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Inserisci l'esponente: ");
        int esponente = int.Parse(Console.ReadLine());

        StampaSaluto(nome, saluto);
        VerificaPari(numeroIntero);
        Console.WriteLine($"la potenza di {baseNum} alla {esponente} è: {CalcolaPotenza(baseNum, esponente)}");
    }

    private static void StampaSaluto(string n, string s)
    {
        Console.Write($"{n}! {s}\n");
    }

    private static void VerificaPari(int n)
    {
        if(n % 2 == 0){Console.WriteLine($"Il numero {n} è pari!");}

        else{Console.WriteLine($"Il numero {n} è dispari!");}
    }

    private static int CalcolaPotenza(int bN, int esp)
    {
        int risultato = 1;
        for (int i = 1; i <= esp; i++)
        {
            risultato *= bN;
        }
        return risultato;
    }
}