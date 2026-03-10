public class DecoratorCioccolato : DecoratoreBevanda
{
    public DecoratorCioccolato(IBevanda component) : base(component)
    {
    }

    public override double Costo()
    {
        double costoBase = base.Costo();
        Console.WriteLine($"Costo prima del cioccolato: {costoBase}");
        double costoCioccolato = costoBase + 0.50d;
        Console.WriteLine($"Costo dopo aggiunta del cioccolato: {costoCioccolato}");
        return costoCioccolato;
    }

    public override string Descrizione()
    {
        return base.Descrizione() + " con cioccolato";
    }
}