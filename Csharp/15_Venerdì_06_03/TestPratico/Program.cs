using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Animale> animali = new List<Animale>();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("========== Menù Gestione Animali ==========");
            Console.WriteLine("[1] Crea un nuovo animale");
            Console.WriteLine("[2] Elimina un animale in lista");
            Console.WriteLine("[3] Filtra lista per tipo animale");
            Console.WriteLine("[4] Fai emettere il loro verso a tutti gli animali");
            Console.WriteLine("[6] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1": //Case che gestisce la creazione di un nuovo animale. Gestisco il tipo tramite if-else dopo la scelta dell'utente 
                    Console.WriteLine("Che animale vuoi aggiungere?");
                    Console.WriteLine("[1] Mucca");
                    Console.WriteLine("[2] Gallina");
                    Console.WriteLine("[3] Pecora");
                    Console.WriteLine("[4] Maiale");
                    Console.Write("Scelta: ");
                    int tipoAnimale = int.Parse(Console.ReadLine());

                    if (tipoAnimale == 1)
                    {
                        Console.Write("Inserisci nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Inserisci età: ");
                        int eta = int.Parse(Console.ReadLine());
                        Console.Write("Inserisci quantità di latte prodotto: ");
                        int quantitaLatte = int.Parse(Console.ReadLine());

                        animali.Add(new Mucca(nome, eta, quantitaLatte));
                    }
                    else if (tipoAnimale == 2)
                    {
                        Console.Write("Inserisci nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Inserisci età: ");
                        int eta = int.Parse(Console.ReadLine());
                        Console.Write("Inserisci quantità di uova prodotte: ");
                        int quantitaUova = int.Parse(Console.ReadLine());

                        animali.Add(new Gallina(nome, eta, quantitaUova));
                    }
                    else if (tipoAnimale == 3)
                    {
                        Console.Write("Inserisci nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Inserisci età: ");
                        int eta = int.Parse(Console.ReadLine());
                        Console.Write("Inserisci quantità di lana prodotta: ");
                        int quantitaLana = int.Parse(Console.ReadLine());

                        animali.Add(new Pecora(nome, eta, quantitaLana));
                    }
                    else if (tipoAnimale == 4)
                    {
                        Console.Write("Inserisci nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Inserisci età: ");
                        int eta = int.Parse(Console.ReadLine());
                        Console.Write("Inserisci peso maiale: ");
                        int peso = int.Parse(Console.ReadLine());

                        animali.Add(new Maiale(nome, eta, peso));
                    }
                    else
                        throw new Exception("Errore selezione indice animale");
                    break;

                case "2": //Mostro la lista degli animali presenti, chiedo all'utente l'indice dell'animale da eliminare
                    if (animali.Count == 0)
                    {
                        Console.WriteLine("Non ci sono animali nella lista.");
                        break;
                    }

                    Console.WriteLine("Animali presenti:");

                    for (int i = 0; i < animali.Count; i++)
                    {
                        Console.WriteLine($"{i} - {animali[i].GetType().Name}");
                    }

                    Console.Write("Inserisci l'indice dell'animale da eliminare: ");
                    int indice = int.Parse(Console.ReadLine());

                    if (indice >= 0 && indice < animali.Count)
                    {
                        animali.RemoveAt(indice);
                        Console.WriteLine("Animale eliminato correttamente.");
                    }
                    else
                    {
                        Console.WriteLine("Indice non valido.");
                    }
                    break;

                case "3": //Chiedo all'utente di scrivere il tipo che vuole ricercare e controllo che quello che ha scritto sia uguale al nome della classe per mostrare tutti gli animali presenti in in lista di quella classe e le loro info
                    if (animali.Count == 0)
                    {
                        Console.WriteLine("Non ci sono animali nella lista.");
                        break;
                    }

                    Console.Write("Inserisci tipo di animale da ricercare (Mucca/Gallina/Pecora/Maiale): ");
                    string tipo = Console.ReadLine();

                    Console.WriteLine($"\nStampa animali di tipo: {tipo}");
                    for (int i = 0; i < animali.Count; i++)
                    {
                        if (tipo == animali[i].GetType().Name)
                            Console.WriteLine($"{i} - {animali[i].MostraInfo()}");
                    }

                    break;

                case "4": //Richiamo il metodo polimofico Verso sulla lista animale in modo che ogni animale produca il proprio verso
                    Console.WriteLine("Riproduzione verso animali presenti in lista:\n");

                    foreach (var a in animali)
                    {
                        a.Verso();
                    }
                    break;

                case "5": //Chiudo il programma impostando la condizione di uscita del loop a false
                    Console.WriteLine("Chiusura programma...");
                    continua = false;
                    break;

                default:
                    throw new Exception("Scelta indice non valida!");
            }
        }
    }
}