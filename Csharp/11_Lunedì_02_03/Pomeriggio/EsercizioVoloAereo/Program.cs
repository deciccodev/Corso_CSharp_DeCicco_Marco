public class Program
{
    public static void Main(string[] args)
    {
        List<VoloAereo> voli = new List<VoloAereo>();

        VoloAereo volo = new VoloAereo();

        bool continua = true;

        do
        {
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("1. Prenota volo");
            Console.WriteLine("2. Annulla volo");
            Console.WriteLine("3. Esci");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci codice volo: ");
                    volo.codiceVolo = Console.ReadLine();
                    if (volo.PostiOccupati < 140)
                    {
                        Console.Write("Quanti posti?: ");
                        int numeroPosti = int.Parse(Console.ReadLine());
                        volo.EffettuaPrenotazione(numeroPosti);
                        volo.VisualizzaStato();
                        voli.Add(volo);
                    }
                    break;
                case "2":
                    Console.Write("Inserisci codice volo: ");
                    volo.codiceVolo = Console.ReadLine();
                    Console.Write("Quanti posti?: ");
                    int posti = int.Parse(Console.ReadLine());

                    List<VoloAereo> tmp = new List<VoloAereo>();
                    foreach (var v in voli)
                    {
                        if (volo.codiceVolo == v.codiceVolo)
                        {
                            tmp.Add(v);
                        }
                    }
                    foreach (var v in tmp)
                    {
                        if (volo.codiceVolo == v.codiceVolo)
                        {
                            voli.Remove(v);
                        } 
                    }

                    volo.AnnullaPrenotazione(posti);
                    volo.VisualizzaStato();
                    break;
                case "3":
                    Console.WriteLine("Chiusura...");
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Errore");
                    break;
            }
        } while (continua);
    }
}