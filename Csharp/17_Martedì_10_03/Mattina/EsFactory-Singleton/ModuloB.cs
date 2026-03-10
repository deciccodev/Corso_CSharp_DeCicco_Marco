public class ModuloB : Creator
{
    public override IDispositivo CreaDispositivo(string type)
    {
        if (type.ToLower() == "stampante")
            return new Stampante();

        return null;
    }
}