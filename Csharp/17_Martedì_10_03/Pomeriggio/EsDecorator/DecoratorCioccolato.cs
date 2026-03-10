public class DecoratorCioccolato : DecoratoreBevanda
{
    public DecoratorCioccolato(IBevanda component) : base(component)
    {
    }

    public override double Costo()
    {
        double costoBase = base.Costo();
        Console.WriteLine($"Costo prima del cioccolato: {costoBase}");
        double costoCioccolato = 0.50d;
        Console.WriteLine($"Costo aggiunta del cioccolato: {costoCioccolato}");
        return costoBase + costoCioccolato;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " con cioccolato";
    }
}