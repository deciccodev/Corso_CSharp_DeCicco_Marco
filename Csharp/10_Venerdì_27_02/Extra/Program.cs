class Program
{
    public static void Main(string[] args)
    {
        //Operatore terniario
        string scelta = "";

        int numero = 0;

        numero = scelta == "10" ? 10 : int.Parse(scelta);


        //Error handling
        int a = 10;
        int b = 0;
        try
        {
            int c = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divisione per zero non consentita");
        }
        finally
        {
            if(b == 0)
            {
                Console.WriteLine("Divisione per zero non consentita");
            }
        }
    }
}


