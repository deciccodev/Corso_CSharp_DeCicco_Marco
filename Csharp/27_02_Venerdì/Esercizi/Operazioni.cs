class Operazioni
{
    public int Somma(int a, int b)
    {
        return a + b;
    }

    public int Moltiplica(int a, int b)
    {
        return a * b;
    }

    public void StampaRisultato(string operazione, int risultato)
    {
        if (operazione == "Somma")
            Console.WriteLine($"\nLa somma dei numeri inseriti è uguale a: {risultato}");

        if (operazione == "Moltiplica")
            Console.WriteLine($"Il prodotto dei numeri inseriti è uguale a: {risultato}\n");
    }
}