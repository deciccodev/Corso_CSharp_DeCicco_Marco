public class Program
{
    public static void Main(string[] args)
    {
        bool continua = true;
        IBevanda caffe = new Caffe();
        IBevanda te = new Te();

        while (continua)
        {
            Console.WriteLine("Che bevanda vuoi acquistare?");
            Console.WriteLine("[1] Caffè");
            Console.WriteLine("[2] Tè");
            Console.WriteLine("[3] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Costo base del caffè: ");
                    Console.WriteLine(caffe.Costo());
                    Console.Write("Vuoi aggiungere qualcosa tra: [1] Latte | [2] Cioccolato | [3] Panna | [4] No Extra: ");
                    int extraCaffe = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    DecoraCaffe(extraCaffe, caffe);
                    break;
                case "2":
                    Console.Write("Costo base del tè: ");
                    Console.WriteLine(te.Costo());
                    Console.Write("Vuoi aggiungere qualcosa tra: [1] Latte | [2] Cioccolato | [3] Panna | [4] No Extra: ");
                    int extraTe = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    DecoraTe(extraTe, te);
                    break;
                case "3":
                    Console.WriteLine("Uscita programma...");
                    continua = false;
                    break;
                default:
                    throw new Exception("Scelta non valida");
            }
        }
    }

    public static void DecoraCaffe(int extraCaffe, IBevanda caffe)
    {
        IBevanda bevandaFinale = caffe;

        switch (extraCaffe)
        {
            case 1:
                bevandaFinale = new DecoratorLatte(caffe);
                break;

            case 2:
                bevandaFinale = new DecoratorCioccolato(caffe);
                break;

            case 3:
                bevandaFinale = new DecoratorPanna(caffe);
                break;

            case 4:
                break;

            default:
                throw new Exception("Scelta non valida");
        }

        Console.WriteLine(bevandaFinale.Descrizione());
        Console.WriteLine($"Costo totale: {bevandaFinale.Costo()}");
        Console.WriteLine();
    }
    public static void DecoraTe(int extraTe, IBevanda te)
    {
        IBevanda bevandaFinale = te;
        switch (extraTe)
        {
            case 1:
                bevandaFinale = new DecoratorLatte(te);
                break;

            case 2:
                bevandaFinale = new DecoratorCioccolato(te);
                break;

            case 3:
                bevandaFinale = new DecoratorPanna(te);
                break;

            case 4:
                break;

            default:
                throw new Exception("Scelta non valida");
        }

        Console.WriteLine(bevandaFinale.Descrizione());
        Console.WriteLine($"Costo totale: {bevandaFinale.Costo()}");
        Console.WriteLine();
    }
}