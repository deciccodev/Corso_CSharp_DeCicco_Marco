public class Program
{
    public static void Main(string[] args)
    {
        Monitor monitor = new Monitor();
        Mouse mouse = new Mouse();
        SchedaVideo schedaVideo = new SchedaVideo();
        Tastiera tastiera = new Tastiera();
        
        IObserver observer = new Logger();
        GamingSetupFacade gamingSetupFacade = GamingSetupFacade.GetInstance(monitor, schedaVideo, tastiera, mouse);

        gamingSetupFacade.Attach(observer);

        gamingSetupFacade.StartSetup();
        Console.WriteLine();

        gamingSetupFacade.SpegniSetup();
        Console.WriteLine();
    }
}