public class Program
{
    List<Docente> docenti = new List<Docente>();
    List<Corso> corsi = new List<Corso>();

    public static void Main(string[] args)
    {
        //TODO IMPLEMENTARE MENU
    }

    public void CreaDocente()
    {
        Console.Clear();

        Console.Write("Inserisci nome docente: ");
        string nomeDocente = Console.ReadLine();
        Console.Write("Inserisci la materia insegnata dal docente: ");
        string materiaInsegnata = Console.ReadLine();
        docenti.Add(new Docente(nomeDocente, materiaInsegnata));
    }

    public void CreaCorso()
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
                    Console.WriteLine($"[{i + 1}] {docenti[i]}");
                }
                Console.Write("Digita l'indice del docente: ");
                int indexDocentePresenza = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Inserisci il nome dell'aula in cui si svolge il corso: ");
                string nomeAula = Console.ReadLine();
                Console.Write("Inserisci il numero di posti disponibili del corso: ");
                int postiDisponibili = int.Parse(Console.ReadLine());
                corsi.Add(new CorsoInPresenza(nomeCorsoPresenza, oreCorsoPresenza, docenti[indexDocentePresenza], nomeAula, postiDisponibili));
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
                break;
            default:
                Console.Write("Errore scelta switch");
                break;
        }
    }
}

