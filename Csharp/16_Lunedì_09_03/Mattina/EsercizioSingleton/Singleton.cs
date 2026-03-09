public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();
    private string nome;
    private string cognome;

    private Singleton(string nome, string cognome)
    {
        this.nome = nome;
        this.cognome = cognome;
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            Console.WriteLine("======== Seconda classe singleton con parametri nel costruttore ========");
            Console.Write("Inserisci Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Inserisci Cognome: ");
            string cognome = Console.ReadLine();
            
            _instance = new Singleton(nome, cognome);
        }
        return _instance;
    }

    public void StampaSingleton()
    {
        Console.WriteLine($"Stampa dati costruttore 2 classe Singleton: {nome} {cognome}");
    }
}
