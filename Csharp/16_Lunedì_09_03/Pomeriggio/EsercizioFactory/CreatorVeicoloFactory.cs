public class CreatorVeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        tipo = tipo.ToLower();

        switch (tipo)
        {
            case "auto":
                return new Auto();
            case "moto":
                return new Moto();
            case "camion":
                return new Camion();
            default:
                throw new ArgumentException("Errore tipo veicolo");
        }
    }
}