public class Program
{
    static void Main()
    {
        bool continua = true;
        
        while (continua)
        {
            Console.Write("Quale veicolo vuoi creare? (auto/moto/camion): ");
            string scelta = Console.ReadLine();

            IVeicolo veicolo = CreatorVeicoloFactory.CreaVeicolo(scelta);

            if (veicolo != null)
            {
                veicolo.Avvia();
                veicolo.MostraTipo();
            }
            else{Console.WriteLine("Tipo di veicolo non valido.");}

            Console.Write("Vuoi continuare? (s/n): ");
            string loop = Console.ReadLine();
            if (loop == "n") {return;}
            Console.Clear();
        }
    }
}