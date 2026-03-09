public class Program
{
    public static void Main(string[] args)
    {
        ConfigurazioneSistema ModuloA = ConfigurazioneSistema.GetInstance();
        ModuloA.Imposta("abc", "- prima configurazione");
        Console.WriteLine();
        ModuloA.Leggi("abc");
        Console.WriteLine($"HashCode logger1: {ModuloA.GetHashCode()}\n");

        ConfigurazioneSistema ModuloB = ConfigurazioneSistema.GetInstance();
        
        ModuloB.Imposta("def", "- seconda configurazione");
        Console.WriteLine();
        ModuloB.Imposta("abc", "- modifica prima configurazione di modulo a da modulo b");
        Console.WriteLine();
        ModuloB.StampaTutte();
        Console.WriteLine($"HashCode logger2: {ModuloA.GetHashCode()}\n");
    }
}