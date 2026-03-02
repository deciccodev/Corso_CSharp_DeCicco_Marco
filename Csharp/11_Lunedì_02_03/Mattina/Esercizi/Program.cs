using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        //EsercizioLibro();
        EsercizioMacchina();
    }


    public static void EsercizioLibro()
    {
        Libro libro1 = new Libro{titolo = "Il signore degli anelli", autore = "J. J. R. Tolkien", annoPubblicazione = 2026};
        Libro libro2 = new Libro{titolo = "Il signore degli anelli", autore = "J. J. R. Tolkien", annoPubblicazione = 2026};

        Console.WriteLine($"{libro1}");
        Console.WriteLine($"{libro1.Equals(libro2)}");
        Console.WriteLine($"Ritorno HashCode Libro 1: {libro1.GetHashCode()}");
        Console.WriteLine($"Ritorno HashCode Libro 2: {libro2.GetHashCode()}\n");

        //METODI SPECIALI EXTRA
        Console.WriteLine($"Tipo Libro 1: {libro1.GetType()}");
        Console.WriteLine($"Controllo Reference Equals su Libro1 e Libro2: {ReferenceEquals(libro1, libro2)}");
        
        Libro libroCopia = libro1.CopiaSuperficiale();
        Console.WriteLine($"Stampa ToString del libro copia di libro1: {libroCopia}");

        Distruttore ex = new Distruttore();
        ex.ShowDuration();
    }

    public static void EsercizioMacchina()
{
    Random random = new Random();
    bool continua = true;

    Console.Write("Inserisci nome utente: ");
    string nome = Console.ReadLine()!;

    Utente utente = new Utente(nome, random.Next(1, 11));

    while (continua && utente.credito > 0)
    {
        Console.WriteLine($"\nScegli una modifica (costo: 1 credito x modifica), credito attuale {utente.credito}");
        Console.WriteLine("1) Aumenta velocità (+10)");
        Console.WriteLine("2) Cambia motore");
        Console.WriteLine("3) Aumenta sospensioni (+1)");
        Console.WriteLine("4) Esci");

        string scelta = Console.ReadLine()!;

        switch (scelta)
        {
            case "1":
                utente.macchina.velocitaMac += 10;
                utente.macchina.nrModifiche++;
                utente.credito--;
                Console.WriteLine("Velocità aumentata!");
                break;

            case "2":
                Console.Write("Inserisci nuovo motore: ");
                string nuovoMotore = Console.ReadLine()!;
                utente.macchina.motore = nuovoMotore;
                utente.macchina.nrModifiche++;
                utente.credito--;
                Console.WriteLine("Motore modificato!");
                break;

            case "3":
                utente.macchina.sospensioniMax += 1;
                utente.macchina.nrModifiche++;
                utente.credito--;
                Console.WriteLine("Sospensioni aumentate!");
                break;

            case "4":
                continua = false;
                break;

            default:
                Console.WriteLine("Scelta non valida!");
                break;
        }
    }

    Console.WriteLine("\n=== RISULTATO FINALE ===");
    Console.WriteLine(utente);
    Console.WriteLine(utente.macchina);
}
}


