public class ContoBancario
{
    //Campo privato
    private double _saldo;

    //Proprietà per accedere al saldo
    public double Saldo
    {
        get { return _saldo; }
        set 
        { 
            if(value >= 0)
            {
                _saldo = value; 
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ContoBancario conto = new ContoBancario();

        conto.Saldo = 1000.50; //Imposta il saldo tramite la proprietà (setter)
        Console.WriteLine(conto.Saldo); //Legge il saldo tramite la proprietà (getter)

        conto.Saldo = -500; //Non modifica il saldo perchè l'importo è negativo e non rispetta la condizione del set
        Console.WriteLine(conto.Saldo);
    }
}