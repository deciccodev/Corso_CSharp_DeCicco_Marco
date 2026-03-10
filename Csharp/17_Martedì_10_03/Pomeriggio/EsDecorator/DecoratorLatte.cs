public class DecoratorLatte : DecoratoreBevanda
{
    public DecoratorLatte(IBevanda component) : base(component)
    {
    }

    public override double Costo()
    {
        double costoBase = base.Costo();
        Console.WriteLine($"Costo prima del latte: {costoBase}");
        double costoLatte = costoBase + 0.20d;
        Console.WriteLine($"Costo dopo aggiunta del latte: {costoLatte}");
        return costoLatte;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " con latte";
    }
}