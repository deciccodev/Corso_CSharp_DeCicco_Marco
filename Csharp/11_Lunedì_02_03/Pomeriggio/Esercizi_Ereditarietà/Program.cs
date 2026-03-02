public class Program
{
    public static void Main(string[] args)
    {
        List<Veicolo> veicoli = new List<Veicolo>();

        bool continua = true;

        do
        {
            Console.WriteLine("1) Inserisci nuovo veicolo");
            Console.WriteLine("2) Visualizzare tutti i veicoli presenti nel garage");
            Console.WriteLine("3) Uscire dal programma");
            Console.Write("Cosa vuoi fare?: ");
            string scelta = Console.ReadLine();
            Console.WriteLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Che tipo di veicolo vuoi inserire?(Auto o Moto): ");
                    string tipoVeicolo = Console.ReadLine();
                    Console.Write("Inserisci marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("inserisci modello: ");
                    string modello = Console.ReadLine();
                    
                    if (tipoVeicolo == "Auto")
                    {
                        Console.Write("Inserisci numero di porte: ");
                        int numPorte = int.Parse(Console.ReadLine());
                        Auto a = new Auto(marca, modello, numPorte);
                        veicoli.Add(a);
                    }

                    else
                    {
                        Console.Write("Inserisci il tipo di manubrio della moto: ");
                        string tManubrio = Console.ReadLine();
                        Moto m = new Moto(marca, modello, tManubrio);
                        veicoli.Add(m);   
                    }

                    Console.Write("Veicolo aggiunto correttamente!\n");
                    break;

                case "2":
                    Console.WriteLine("I veicoli presenti in garage sono i seguenti:");
                    foreach (var v in veicoli)
                    {
                        v.StampaInfo();
                    }
                    break;

                case "3":
                    continua = false;
                    Console.WriteLine("Chiusura programma...\n");
                    break;
                default:
                    Console.WriteLine("Scelta non consentita!");
                    break;
            }
        } while (continua);
    }
}