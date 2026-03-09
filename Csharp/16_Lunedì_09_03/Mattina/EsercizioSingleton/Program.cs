public class Program
{
    public static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.ScriviMessaggio("Prima prova instanza singleton");
        Console.WriteLine($"HashCode logger1: {logger1.GetHashCode()}\n");

        Logger logger2 = Logger.GetInstance();
        logger1.ScriviMessaggio("Seconda prova instanza singleton");
        Console.WriteLine($"HashCode logger2: {logger2.GetHashCode()}\n");

        Singleton singleton = Singleton.GetInstance();
        singleton.StampaSingleton();
    }
}