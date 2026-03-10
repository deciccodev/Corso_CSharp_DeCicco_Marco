public class DecoratorPanna : DecoratoreBevanda
{
    public DecoratorPanna(IBevanda component) : base(component)
    {
    }

    public override double Costo()
    {
        double costoBase = base.Costo();
        Console.WriteLine($"Costo prima della panna: {costoBase}");
        double costoPanna = costoBase + 0.30d;
        Console.WriteLine($"Costo dopo aggiunta della panna: {costoPanna}");
        return costoPanna;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " con panna";
    }
}