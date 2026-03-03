public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Inserisci destinazione volo: ");
        string destinazione = Console.ReadLine();

        PrenotazioneViaggio viaggio = new PrenotazioneViaggio(destinazione);

        viaggio.PrenotaVolo(viaggio.PrenotaPosti, viaggio.AnnullaPrenotazione);
    }
}
