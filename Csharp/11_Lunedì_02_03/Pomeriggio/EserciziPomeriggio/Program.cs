using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Film> films = new List<Film>();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("1) Inserisci nuovo film");
            Console.WriteLine("2) Ricerca film per genere");
            Console.WriteLine("3) Stampa lista completa di film ed esci");
            Console.WriteLine("4) Prova metodo extra GetType()");
            Console.WriteLine("5) Prova metodo extra ReferenceEquals");
            Console.Write("Cosa vuoi fare?: ");
            string scelta = Console.ReadLine()!;
            Console.WriteLine();
            
            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci il titolo del film: ");
                    string titolo = Console.ReadLine()!;
                    Console.Write("Inserisci il regista del film: ");
                    string regista = Console.ReadLine()!;
                    Console.Write("Inserisci l'anno di uscita del film: ");
                    int anno = int.Parse(Console.ReadLine()!);
                    Console.Write("Inserisci il genere del film film: ");
                    string genere = Console.ReadLine()!;
                    Console.WriteLine();

                    films.Add(new Film(titolo, regista, anno, genere));
                    Console.Write("Film inserito correttamente!\n");
                    break;

                case "2":
                    Console.Write("Inserisci il genere da ricercare: ");
                    string ricerca = Console.ReadLine()!;
                    foreach (var film in films)
                    {
                        if (film.genere == ricerca)
                        {
                            Console.Write(film);
                        }
                        else{Console.WriteLine($"Nessun film di genere {ricerca} trovato!\n");}
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("Lista intera di tutti i film inseriti:");
                    foreach (var film in films)
                    {
                        Console.WriteLine(film);
                    }
                    Console.WriteLine();
                    continua = false;
                    break;

                case "4":
                    Console.WriteLine($"Stampa tipo della lista di oggetti Film: {films.GetType()}\n");
                    break;
                
                case "5":
                    Console.WriteLine($"Stampa ReferenceEquals della lista di oggetti Film:");
                    foreach (var film in films)
                    {
                        Console.WriteLine(ReferenceEquals(film, films));
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Scelta non consentita!");
                    break;
            }
        }    
    }
}