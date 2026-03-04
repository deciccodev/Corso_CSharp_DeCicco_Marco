using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Operatore> op = new List<Operatore>();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("1. Aggiungi Operatore");
            Console.WriteLine("2. Stampa tutti gli operatori");
            Console.WriteLine("3. EseguiCompito() su tutti gli operatori");
            Console.WriteLine("4. Esci");
            Console.Write("Cosa vuoi fare?: ");

            string scelta = Console.ReadLine();
            
            switch (scelta)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Inserisci nome operatore: ");
                    string nomeOp = Console.ReadLine();
                    Console.Write("Inserisci turno operatore (giorno/notte): ");
                    string turnoOp = Console.ReadLine();
                    Console.Write("1. Emergenza \n2. Sicurezza \n3. Logistica \nInserisci tipo di operatore: ");
                    string tipoOp = Console.ReadLine();
                    
                    if(tipoOp == "1")
                    {
                        Console.Write("Inserisci livello emergenza: ");
                        int emergenzaOp = int.Parse(Console.ReadLine());
                        op.Add(new OperatoreEmergenza(nomeOp, turnoOp, emergenzaOp));
                        Console.WriteLine("Operatore Emergenza inserito correttamente!");
                    }
                    else if(tipoOp == "2")
                    {
                        Console.Write("Inserisci area di sorveglianza: ");
                        string areaSorveglianza = Console.ReadLine();
                        op.Add(new OperatoreSicurezza(nomeOp, turnoOp, areaSorveglianza));
                        Console.WriteLine("Operatore Sicurezza inserito correttamente!");
                    }
                    else
                    {
                        Console.Write("Inserisci numero di consegne: ");
                        int numeroConsegne = int.Parse(Console.ReadLine());
                        op.Add(new OperatoreLogistica(nomeOp, turnoOp, numeroConsegne));
                        Console.WriteLine("Operatore Emergenza inserito correttamente!");
                    }
                    break;

                case "2":
                    Console.Clear();

                    if(op.Count > 0)
                    {
                        for (int i = 0; i < op.Count; i++)
                        {
                            Console.WriteLine(op[i]);
                        }   
                    }
                    else { Console.WriteLine("Non sono presenti operatori in lista!"); }
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("Eseguendo compito su tutti gli operatori...");

                    for (int i = 0; i < op.Count; i++)
                    {
                        op[i].EseguiCompito();
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    
                    break;

                case "4":
                    Console.WriteLine("Uscita Programma...");
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Errore");
                    break;
            }
            
        }
    }
}