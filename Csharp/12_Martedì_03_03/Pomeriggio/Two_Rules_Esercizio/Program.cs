using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Soldato> s = new List<Soldato>();

        Esercito e = new Esercito("Nome", "Grado", 0);

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("1. Aggiungi Fante");
            Console.WriteLine("2. Aggiungi Artigliere");
            Console.WriteLine("3. Visualizza tutti i soldati con Descrizione()");
            Console.WriteLine("4. Esci");
            Console.WriteLine("5. Visualizza tutti i soldati con Descrizione() tramite l'oggetto Esercito");
            Console.Write("Cosa vuoi fare?: ");

            string scelta = Console.ReadLine();
            
            switch (scelta)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Inserisci nome fante: ");
                    string nomeFante = Console.ReadLine();
                    Console.Write("Inserisci grado fante: ");
                    string gradoFante = Console.ReadLine();
                    Console.Write("Inserisci anni di servizio fante: ");
                    int anniServizioFante = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci arma del fante: ");
                    string arma = Console.ReadLine();
                    
                    s.Add(new Fante(nomeFante, gradoFante, anniServizioFante, arma));
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Inserisci nome artigliere: ");
                    string nomeArtigliere = Console.ReadLine();
                    Console.Write("Inserisci grado artigliere: ");
                    string gradoArtigliere = Console.ReadLine();
                    Console.Write("Inserisci anni di servizio artigliere: ");
                    int anniServizioArtigliere = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci calibro del artigliere: ");
                    int calibro = int.Parse(Console.ReadLine());
                    
                    s.Add(new Artigliere(nomeArtigliere, gradoArtigliere, anniServizioArtigliere, calibro));
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("Stampa Soldati con descrizione in corso...");

                    for (int i = 0; i < s.Count; i++)
                    {
                        s[i].Descrizione();
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    
                    break;

                case "4":
                    Console.WriteLine("Uscita Programma...");
                    continua = false;
                    break;

                case "5":
                    Console.Clear();

                    Console.WriteLine("Stampa Soldati con descrizione da oggetto Esercito...");

                    Console.WriteLine();
                    e.StampaDettagli(s);
                    Console.WriteLine();
                    
                    break;

                default:
                    Console.WriteLine("Errore");
                    break;
            }
            
        }
    }
}