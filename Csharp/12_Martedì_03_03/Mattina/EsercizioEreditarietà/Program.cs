using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool continua = true;
        List<Corso> corsi = new List<Corso>();

        while (continua)
        {
            Console.WriteLine("1. Aggiungi corso di musica");
            Console.WriteLine("2. Aggiungi corso di pittura");
            Console.WriteLine("3. Aggiungi corso di danza");
            Console.WriteLine("4. Aggiungi studente ad un corso");
            Console.WriteLine("5. Visualizza tutti i corsi");
            Console.WriteLine("6. Cerca corsi per nome docente");
            Console.WriteLine("7. Esegui metodo speciale di un corso");
            Console.WriteLine("8. Esci");
            Console.Write("Cosa vuoi fare?: ");

            string scelta = Console.ReadLine();
            
            switch (scelta)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Inserisci nome corso: ");
                    string nomeCorsoMusica = Console.ReadLine();
                    Console.Write("Inserisci durata ore: ");
                    int durataOreMusica = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci nome docente del corso: ");
                    string nomeDocenteMusica = Console.ReadLine();
                    Console.Write("Inserisci strumento del corso: ");
                    string strumento = Console.ReadLine();

                    corsi.Add(new CorsoMusica(nomeCorsoMusica, durataOreMusica, nomeDocenteMusica, strumento));
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Inserisci nome corso: ");
                    string nomeCorsoPittura = Console.ReadLine();
                    Console.Write("Inserisci durata ore: ");
                    int durataOrePittura = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci nome docente del corso: ");
                    string nomeDocentePittura = Console.ReadLine();
                    Console.Write("Inserisci tecnica del corso: ");
                    string tecnica = Console.ReadLine();

                    corsi.Add(new CorsoPittura(nomeCorsoPittura, durataOrePittura, nomeDocentePittura, tecnica));
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Inserisci nome corso: ");
                    string nomeCorsoDanza = Console.ReadLine();
                    Console.Write("Inserisci durata ore: ");
                    int durataOreDanza = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci nome docente del corso: ");
                    string nomeDocenteDanza = Console.ReadLine();
                    Console.Write("Inserisci stile del corso: ");
                    string stile = Console.ReadLine();

                    corsi.Add(new CorsoDanza(nomeCorsoDanza, durataOreDanza, nomeDocenteDanza, stile));
                    break;

                case "4":
                    Console.Clear();

                    if (corsi.Count == 0)
                    {
                        Console.WriteLine("Nessun corso disponibile.");
                        break;
                    }

                    for (int i = 0; i < corsi.Count; i++)
                        Console.WriteLine($"[{i + 1}] {corsi[i].NomeCorso}");

                    Console.Write("Seleziona indice corso: ");
                    int indiceStudente = int.Parse(Console.ReadLine());

                    if (indiceStudente >= 0 && indiceStudente < corsi.Count)
                    {
                        Console.Write("Nome studente: ");
                        string studente = Console.ReadLine();
                        corsi[indiceStudente].AggiungiStudente(studente);
                    }
                    else
                        Console.WriteLine("Indice non valido.");

                    break;

                case "5":
                    Console.Clear();

                    if (corsi.Count == 0)
                    {
                        Console.WriteLine("Nessun corso presente.");
                        break;
                    }

                    for (int i = 0; i < corsi.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {corsi[i]}");
                    }
                    break;

                case "6":
                    Console.Clear();

                    Console.Write("Inserisci nome docente da cercare: ");
                    string ricercaDocente = Console.ReadLine();

                    bool trovato = false;

                    foreach (var corso in corsi)
                    {
                        if (corso.Docente.ToLower() == ricercaDocente.ToLower())
                        {
                            Console.WriteLine(corso.ToString());
                            trovato = true;
                        }
                    }

                    if (!trovato)
                        Console.WriteLine("Nessun corso trovato per questo docente.");

                    break;

                case "7":
                    Console.Clear();

                    if (corsi.Count == 0)
                    {
                        Console.WriteLine("Nessun corso disponibile.");
                        break;
                    }

                    for (int i = 0; i < corsi.Count; i++)
                        Console.WriteLine($"[{i + 1}] {corsi[i].NomeCorso}");

                    Console.Write("Seleziona indice corso: ");
                    int indiceMetodo = int.Parse(Console.ReadLine()) - 1;

                    if (indiceMetodo >= 0 && indiceMetodo < corsi.Count)
                        corsi[indiceMetodo].MetodoSpeciale();
                    else
                        Console.WriteLine("Indice non valido.");

                    break;

                case "8":
                    Console.WriteLine("Uscita Programma...");
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Errore");
                    break;
            }
            
        }
    }
}