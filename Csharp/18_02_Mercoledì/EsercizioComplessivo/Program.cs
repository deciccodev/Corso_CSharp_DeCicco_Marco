using System;

class EsercizioComplessivo
{
    public static void Main(string[] args)
    {
        string login = "", nomeUtente = "admin";
        int password = 000;
        bool continua = true;

        Console.Write("Hai già un account? si/no: ");
        login = Console.ReadLine();

        while (continua)
        {
            switch (login)
            {
                case "no":
                    //CASO NUOVO UTENTE: CREAZIONE CREDENZIALI DI ACCESSO
                    Console.Write("Inserisci il tuo nome utente: ");
                    nomeUtente = Console.ReadLine();
                    Console.Write("Inserisci la tua password: ");
                    password = int.Parse(Console.ReadLine());

                    //UTILIZZO UNA DOMANDA DOPO LA CREAZIONE DELL'ACCOUNT PER FAR METTERE IN INPUT ALL'UTENTE LA CONDIZIONE PER CAMBIARE CASO DELLO SWITCH
                    Console.Write("Account creato correttamente! \nVuoi effettuare l'accesso? (si/no): ");
                    string login_tmp = Console.ReadLine();

                    if (login_tmp == "si"){login = login_tmp;}
                    else{
                        //TERMINO IL PROGRAMMA SE L'UTENTE NON VUOLE LOGGARE DOPO ESSERSI REGISTRATO
                        Console.Write("Chiusura programma...");
                        return;}
                    break;
                case "si":
                    //CONTROLLO CHE I DATI DI ACCESSO CREATI SIANO CORRETTI
                    Console.Write("Inserisci il tuo nome utente: ");
                    string tmp = Console.ReadLine();
                    if(tmp != nomeUtente)
                    {
                        Console.WriteLine("Nome utente non valido!");
                        break;
                    }

                    Console.Write("Inserisci la tua password: ");
                    int tmp_password = int.Parse(Console.ReadLine());
                    if(tmp_password != password)
                    {
                        Console.WriteLine("Password non valida!");
                        break;
                    }


                    else //SE I DATI SONO CORRETTI ENTRO NEL SISTEMA, PERMETTENDO ESEGUIRE CONTI ALLA ROVESCIA FINCHE' L'UTENTE NON DECIDE DI USCIRE
                    {
                        do
                        {    
                            Console.Write("Inserisci da dove far partire il conto alla rovescia: ");
                            int countdown = int.Parse(Console.ReadLine());

                            Console.WriteLine($"conto alla rovescia: ");
                            for (int i = countdown; i >= 0; i--)
                            {                               
                                Console.WriteLine(i);
                            }

                            Console.Write("Vuoi continuare? (true/false): ");
                            continua = bool.Parse(Console.ReadLine());
                        } while (continua);
                    }                
                    break;
                default:
                    Console.WriteLine("Errore nel sistema");
                    break;
            }
        
        }

    }
}