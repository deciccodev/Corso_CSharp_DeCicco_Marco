public class Program
{
    public static void Main(string[] args)
    {
        List<Docente> docenti = new List<Docente>();
        List<Corso> corsi = new List<Corso>();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nCosa vuoi fare?");
            Console.WriteLine("1. Aggiungi docente");
            Console.WriteLine("2. Aggiungi corso");
            Console.WriteLine("3. Stampa tutti i corsi");
            Console.WriteLine("4. Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    CreaDocente(docenti);
                    break;
                case "2":
                    if (docenti.Count == 0)
                    {
                        Console.WriteLine("Nessun docente disponibile, aggiungine uno prima!");
                        break;
                    }
                    CreaCorso(corsi, docenti);
                    break;
                case "3":
                    Console.Clear();
                    if (corsi.Count == 0)
                    {
                        Console.WriteLine("Nessun corso presente!");
                        break;
                    }
                    foreach (var corso in corsi)
                    {
                        corso.StampaDettagli();
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    Console.WriteLine("Chiusura...");
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }
    }

    public static void CreaDocente(List<Docente> docenti)
    {
        Console.Clear();
        Console.Write("Inserisci nome docente: ");
        string nomeDocente = Console.ReadLine();
        Console.Write("Inserisci la materia insegnata dal docente: ");
        string materiaInsegnata = Console.ReadLine();
        docenti.Add(new Docente(nomeDocente, materiaInsegnata));
        Console.WriteLine("Docente aggiunto correttamente!");
    }

    public static void CreaCorso(List<Corso> corsi, List<Docente> docenti)
    {
        Console.Clear();
        Console.Write("Il corso sarà: [1] Presenza | [2] Online -> ");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                Console.Write("Inserisci il nome del corso: ");
                string nomeCorsoPresenza = Console.ReadLine();
                Console.Write("Inserisci la durata in ore del corso: ");
                int oreCorsoPresenza = int.Parse(Console.ReadLine());
                Console.WriteLine("Seleziona un docente dalla lista per assegnarlo al corso: ");
                for (int i = 0; i < docenti.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {docenti[i].Nome}");
                }
                Console.Write("Digita l'indice del docente: ");
                int indexDocentePresenza = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Inserisci il nome dell'aula in cui si svolge il corso: ");
                string nomeAula = Console.ReadLine();
                Console.Write("Inserisci il numero di posti disponibili del corso: ");
                int postiDisponibili = int.Parse(Console.ReadLine());
                corsi.Add(new CorsoInPresenza(nomeCorsoPresenza, oreCorsoPresenza, docenti[indexDocentePresenza], nomeAula, postiDisponibili));
                Console.WriteLine("Corso in presenza aggiunto correttamente!");
                break;
            case "2":
                Console.Write("Inserisci il nome del corso: ");
                string nomeCorsoOnline = Console.ReadLine();
                Console.Write("Inserisci la durata in ore del corso: ");
                int oreCorsoOnline = int.Parse(Console.ReadLine());
                Console.WriteLine("Seleziona un docente dalla lista per assegnarlo al corso: ");
                for (int i = 0; i < docenti.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {docenti[i]}");
                }
                Console.Write("Digita l'indice del docente: ");
                int indexDocenteOnline = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Inserisci il nome della piattaforma dove si svolge il corso: ");
                string nomePiattaforma = Console.ReadLine();
                Console.Write("Inserisci il link di accesso al corso: ");
                string linkAccesso = Console.ReadLine();
                corsi.Add(new CorsoOnline(nomeCorsoOnline, oreCorsoOnline, docenti[indexDocenteOnline], nomePiattaforma, linkAccesso));
                Console.WriteLine("Corso online aggiunto correttamente!");
                break;
            default:
                Console.WriteLine("Scelta non valida!");
                break;
        }
    }
}