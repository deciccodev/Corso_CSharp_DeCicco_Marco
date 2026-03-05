public abstract class DispositivoElettronico
{
    protected string Modello;

    public DispositivoElettronico(string Modello)
    {
        this.Modello = Modello;
    }

    abstract public void Accendi(); 
    abstract public void Spegni();
    
    public virtual void MostraInfo()
    {
        Console.WriteLine("Sono un dispositivo elettronico");
    }
}