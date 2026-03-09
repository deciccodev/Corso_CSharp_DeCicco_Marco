public class Program
{
    public static void Main(string[] args)
    {
        ConfigurazioneSistema ModuloA = ConfigurazioneSistema.GetInstance();
        
        ModuloA.Imposta("abc", "prima configurazione");
        ModuloA.Leggi("abc");
        Console.WriteLine($"HashCode Modulo A: {ModuloA.GetHashCode()}\n");

        ConfigurazioneSistema ModuloB = ConfigurazioneSistema.GetInstance();
        
        ModuloB.Imposta("def", "seconda configurazione");
        ModuloB.Imposta("abc", "modifica prima configurazione di modulo a da modulo b");
        ModuloB.StampaTutte();
        Console.WriteLine($"HashCode Modulo B: {ModuloA.GetHashCode()}\n");
    }
}