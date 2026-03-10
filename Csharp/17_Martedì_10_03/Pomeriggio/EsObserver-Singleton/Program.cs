public class Program
{
    public static void Main(string[] args)
    {
        NewsAgency sNewsAgency = NewsAgency.GetInstance();

        MobileApp obMobile1 = new MobileApp();
        MobileApp obMobile2 = new MobileApp();
        EmailClient obEmail = new EmailClient();

        sNewsAgency.AttachMobile(obMobile1);
        sNewsAgency.AttachMobile(obMobile2);
        sNewsAgency.AttachEmail(obEmail);

        bool continua = true;

        while (continua)
        {
            #region MENU' TESTUALE
            Console.WriteLine("======= MENU NEWS =======");
            Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("[1] Invia news mobile");
            Console.WriteLine("[2] Invia email");
            Console.WriteLine("[3] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();
            Console.WriteLine();
            #endregion

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci la news da mandare: ");
                    string newsMobile = Console.ReadLine();
                    sNewsAgency.NewsMobile = newsMobile;
                    Console.WriteLine();
                    break;

                case "2":
                    Console.Write("Inserisci email da mandare: ");
                    string newsEmail = Console.ReadLine();
                    sNewsAgency.NewsEmail = newsEmail;
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Chiusura programma...");
                    continua = false;
                    break;

                default:
                    throw new Exception("Scelta non valida");
            }
        }
    }
}