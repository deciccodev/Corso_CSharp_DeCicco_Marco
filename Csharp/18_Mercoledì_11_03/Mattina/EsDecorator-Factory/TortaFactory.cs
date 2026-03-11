public static class TortaFactory //classe statica del pattern factory method, si occupa di creare gli oggetti reali alla necessità
{
    public static ITorta CreaTortaBase(string torta) //metodo per creare i vari tipi di oggetti presenti nella factory
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