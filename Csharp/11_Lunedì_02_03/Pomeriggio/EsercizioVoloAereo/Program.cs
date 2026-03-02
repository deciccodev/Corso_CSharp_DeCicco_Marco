public class Program
{
    public static void Main(string[] args)
    {
        VoloAereo volo = new VoloAereo();
        bool continua = true;

        do
        {
            Console.WriteLine("\nCosa vuoi fare?");
            Console.WriteLine("1. Prenota volo");
            Console.WriteLine("2. Annulla prenotazione");
            Console.WriteLine("3. Esci");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci codice volo: ");
                    volo.CodiceVolo = Console.ReadLine();
                    Console.Write("Quanti posti?: ");
                    int numeroPosti = int.Parse(Console.ReadLine());
                    volo.EffettuaPrenotazione(numeroPosti);
                    volo.VisualizzaStato();
                    break;

                case "2":
                    Console.Write("Inserisci codice volo: ");
                    volo.CodiceVolo = Console.ReadLine();
                    Console.Write("Quanti posti da annullare?: ");
                    int posti = int.Parse(Console.ReadLine());
                    volo.AnnullaPrenotazione(posti);
                    volo.VisualizzaStato();
                    break;

                case "3":
                    Console.WriteLine("Chiusura...");
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        } while (continua);
    }
}