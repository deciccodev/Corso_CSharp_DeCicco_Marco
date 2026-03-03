public class Program
{
    public static void Main(string[] args)
    {
        List<Veicolo> veicoli = new List<Veicolo>()
        {
            new Auto("abc"),
            new Moto("def"),
            new Camion("ghi")
        };

        foreach (Veicolo v in veicoli)
        {
            v.Ripara();
        }
    }
}