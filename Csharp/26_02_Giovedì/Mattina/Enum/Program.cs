public class Nemico
{
    public enum TipoNemico{Zombie, Robot, Fantasma}

    private TipoNemico tipo;

    private void Main(string[] args)
    {
        switch (tipo)
        {
            case TipoNemico.Zombie:
                Console.WriteLine("Questo è uno Zombie");
                break;
            case TipoNemico.Robot:
                Console.WriteLine("Questo è un Robot");
                break;
            case TipoNemico.Fantasma:
                Console.WriteLine("Questo è un Fantasma");
                break;
            default:
                break;
        }
    }
}