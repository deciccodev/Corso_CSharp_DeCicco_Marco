public class Program
{
    public static void Main(string[] args)
    {
        CentroMeteo centroMeteo = new CentroMeteo();

        DisplayConsole displayConsole = new DisplayConsole("Display Console");
        DisplayMobile displayMobile = new DisplayMobile("Display Mobile");

        centroMeteo.Attach(displayConsole);
        centroMeteo.Attach(displayMobile);

        bool continua = true;

        while (continua)
        {
            Console.Write("Inserisci lo stato del meteo: ");
            string stato = Console.ReadLine();

            centroMeteo.AggiornaMeteo(stato);

            Console.Write("Inserire altro stato? s/n: ");
            string loop = Console.ReadLine();

            if (loop.ToLower() == "n") { continua = false; }
        }
    }
}