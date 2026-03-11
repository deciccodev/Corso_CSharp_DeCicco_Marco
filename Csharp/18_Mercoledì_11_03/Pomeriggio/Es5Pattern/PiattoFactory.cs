public static class PiattoFactory //classe factory che si occupa di creare il piatto base a seconda della scelta da parte dell'utente
{
    public static IPiatto Crea(string tipoPiatto)
    {
        string tipo = tipoPiatto.ToLower();

        switch (tipo)
        {
            case "1":
                return new Pizza();
            case "2":
                return new Hamburger();
            case "3":
                return new Insalata();
            default:
                throw new ArgumentException("Tipo piatto non valido!");
        }
    }
} 