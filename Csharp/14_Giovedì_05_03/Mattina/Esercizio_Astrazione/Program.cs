public class Program
{
    public static void Main(string[] args)
    {
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>()
        {
            new Computer("lenovo"),
            new Stampante("brother"),
            new Computer("asus"),
            new Stampante("printer"),
        };

        foreach (DispositivoElettronico d in dispositivi)
        {
            d.MostraInfo();
            d.Accendi();
            d.Spegni();
            Console.WriteLine();
        }
    }
}