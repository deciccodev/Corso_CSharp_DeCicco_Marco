public static class TortaFactory
{
    public static ITorta CreaTortaBase(string torta)
    {
        string tipo = torta.ToLower();

        switch (tipo)
        {
            case "cioccolato":
                return new TortaCioccolato();
            case "vaniglia":
                return new TortaVaniglia();
            case "frutta":
                return new TortaFrutta();
            default:
                throw new ArgumentException("Torta non valida");
        }
    }
}