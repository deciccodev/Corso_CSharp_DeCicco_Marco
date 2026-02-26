using System;

class Esercizi
{
    public static void Main(string[] args)
    {
        //Rubrica();
        //ContaParole();
        Magazzino();
    }

    public static void Rubrica()
    {
        Dictionary<string, string> rubrica = new Dictionary<string, string>();
        string key = "", value = "";

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Inserisci il Nome del contatto: ");
            key = Console.ReadLine();
            Console.WriteLine("Inserisci il Numero del contatto: ");
            value = Console.ReadLine();

            rubrica.Add(key, value);
        }

        foreach (var item in rubrica)
        {
            Console.WriteLine($"Nome contatto: {item.Key}, Numero contatto: {item.Value}");
        }
    }

    public static void ContaParole()
    {
        Console.WriteLine("Inserisci una frase: ");
        string frase = Console.ReadLine();

        string[] parole = frase.Split(' ');

        Dictionary<string, int> frequenzeParola = new Dictionary<string, int>();

        foreach (string parola in parole)
        {
            string p = parola.ToLower();

            if (frequenzeParola.ContainsKey(p))
                frequenzeParola[p]++;
            else
                frequenzeParola[p] = 1;
        }

        Console.WriteLine("\nFrequenza delle parole:");

        foreach (var elemento in frequenzeParola)
        {
            Console.WriteLine($"Parola: {elemento.Key} - Frequenza: {elemento.Value}");
        }
    }

    public static void Magazzino()
    {
        Dictionary<string, int> magazzino = new Dictionary<string, int>();

        bool Esci = true;

        do
        {
            Console.WriteLine("---------- MAGAZZINO ----------");
            Console.Write("1. Modifica quantità di un prodotto \n2. Rimuovi prodotto \n3. Ricerca di un prodotto e relativa quantità disponibile \n4. Stampa inventario \n5. Esci \n");
            Console.Write("\nCosa vuoi fare?: ");

            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    string prodotto = "";
                    int quantita = 0;

                    Console.Write("Nome del prodotto: ");
                    prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        Console.Write("Prodotto già presente! Inserire quantità da aggiungere o rimuovere: ");
                        quantita = int.Parse(Console.ReadLine());

                        magazzino[prodotto] += quantita;
                        Console.WriteLine("Operazione eseguita correttamente!\n");
                    }
                    else
                    {
                        Console.Write("Prodotto non presente! Inserire quantità prodotto da aggiungere: ");
                        quantita = int.Parse(Console.ReadLine());

                        if (quantita > 0)
                        {
                            magazzino[prodotto] = quantita;
                            Console.WriteLine("Prodotto Aggiunto correttamente!\n");                            
                        }
                        else
                        {
                            Console.WriteLine("Errore, Quantità inserita minore di 0\n");
                        }
                    }
                    break;
                case "2":
                    Console.Write("Nome del prodotto da rimuovere completamente: ");
                    prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        magazzino.Remove(prodotto);
                        Console.WriteLine("Prodotto rimosso correttamente!\n");
                    }
                    else
                    {
                        Console.WriteLine("Prodotto non presente in magazzino! Impossibile rimuoverlo\n");
                    }
                    break;
                case "3":
                    Console.Write("Inserire nome prodotto per la quale visualizzare le informazioni: ");
                    prodotto = Console.ReadLine();

                    if (magazzino.ContainsKey(prodotto))
                    {
                        foreach (var p in magazzino)
                        {
                            if (p.Key == prodotto){Console.Write($"In magazzino ci sono {p.Value} scorte del prodotto {p.Key}\n");}                        
                        }
                    }
                    else{Console.WriteLine("Prodotto non presente in magazzino!\n");}
                    break;
                case "4":
                    Console.WriteLine("\nNel magazzino sono presenti i seguenti prodotti:");
                    foreach (var item in magazzino)
                    {
                        Console.WriteLine($"Nome: {item.Key}, Quantità: {item.Value}");
                    }
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Chiusura programma...");
                    Esci = false;
                    break;
                default:
                    Console.Write("\nOperazione non consentita!\n");
                    break;
            }
        } while (Esci);
    }
}