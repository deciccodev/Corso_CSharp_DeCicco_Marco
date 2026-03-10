public class ModuloA : Creator
{
    public override IDispositivo CreaDispositivo(string type)
    {
        if (type.ToLower() == "computer")
            return new Computer();

        return null;
    }
}