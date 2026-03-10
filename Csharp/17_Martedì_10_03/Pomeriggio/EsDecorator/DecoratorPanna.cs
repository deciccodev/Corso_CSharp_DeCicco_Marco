public class DecoratorPanna : DecoratoreBevanda
{
    public DecoratorPanna(IBevanda component) : base(component)
    {
    }

    public override double Costo()
    {
        double costoBase = base.Costo();
        Console.WriteLine($"Costo prima della panna: {costoBase}");
        double costoPanna = 0.30d;
        Console.WriteLine($"Costo aggiunta della panna: {costoPanna}");
        return costoBase + costoPanna;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " con panna";
    }
}