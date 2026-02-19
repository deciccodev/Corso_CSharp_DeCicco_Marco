using System;

class EserciziPomeriggio
{
    public static void Main(string[] args)
    {
        //ESERCIZIO ARRAY - FOREACH
        bool continua = true;

        Console.WriteLine("Di che tipo vuoi creare il tuo array? (int/string): ");
        string scelta = Console.ReadLine();

        Console.WriteLine("Quanto deve essere lungo l'array?");
        int lunghezza = int.Parse(Console.ReadLine());

        do
        {
            switch (scelta)
            {
                case "si":
                    Console.WriteLine("Di che tipo vuoi creare il tuo array? (int/string): ");
                    scelta = Console.ReadLine();

                    Console.WriteLine("Quanto deve essere lungo l'array?");
                    lunghezza = int.Parse(Console.ReadLine());
                    break;
                case "int":
                    int[] arrayInteri = new int[lunghezza];

                    for (int i = 0; i < arrayInteri.Length; i++)
                    {
                        Console.WriteLine("inserisci numero");
                        arrayInteri[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Stampa array in corso...");

                    foreach (int numero in arrayInteri)
                    {
                        Console.WriteLine(numero);
                    }

                    Console.Write("Vuoi continuare? (true/false): ");
                    continua = bool.Parse(Console.ReadLine());
                    if(continua)
                    {
                        scelta = "si";
                        break;
                    }               
                    break;
                case "string":
                    string[] arrayStringhe = new string[lunghezza];

                    for (int i = 0; i < arrayStringhe.Length; i++)
                    {
                        Console.WriteLine("inserisci stringa");
                        arrayStringhe[i] = Console.ReadLine();
                    }

                    Console.WriteLine("Stampa array in corso...");

                    foreach (string stringa in arrayStringhe)
                    {
                        Console.WriteLine(stringa);
                    }

                    Console.Write("Vuoi continuare? (true/false): ");
                    continua = bool.Parse(Console.ReadLine());
                    if(continua)
                    {
                        scelta = "si";
                        break;
                    }                
                    break;
                default:
                    Console.WriteLine("Errore di sistema");
                    break;
            }
        } while (continua);


        //ESERCIZIO FOREACH 1
        Console.WriteLine("Inserisci una frase: ");
        string frase = Console.ReadLine();

        char[] numeri = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        int count = 0;

        foreach (char numero in numeri)
        {
            if(frase.Contains(numero))
            {
                count++;
            }
        }
        Console.WriteLine($"Nella frase sono contenuti {count} numeri");


        //ESERCIZIO FOREACH 2
        Console.WriteLine("Inserisci una frase: ");
        string frase2 = Console.ReadLine();

        string noSpazi = "";
        
        foreach (char carattere in frase2)
        {
            if (carattere != ' ')
            {
                noSpazi += carattere;
            }
        }
        Console.WriteLine(noSpazi);


        //ESERCIZIO FOREACH 3
        Console.WriteLine("Inserisci una frase: ");
        string frase3 = Console.ReadLine();
        int cont = 0;

        string confronto = "aeiou";
        string risultato = frase3.ToLower();

        foreach (char carattere in confronto)
        {
            if(risultato.Contains(carattere))
            {
                cont++;
            }
        }
        Console.WriteLine(cont);


        //ESERCIZIO FOREACH 4
        Console.WriteLine("Inserisci una password: ");
        string pass = Console.ReadLine();

        bool isLegal = false;
        int countPass = 0;

        if(pass.Length >= 8)
        {
            if(!pass.StartsWith(' ') && !pass.EndsWith(' '))
            {
                foreach (char carattere in pass)
                {
                    if(char.IsUpper(carattere)) {countPass++;}                
                }

                if(countPass >= 1)
                {
                    countPass = 0;
                    foreach (char carattere in pass)
                    {
                        if(char.IsDigit(carattere)) 
                        {
                            countPass++;
                            isLegal = true;
                        }                
                    }
                }
            }
        }
        if(isLegal)
        {
            Console.WriteLine("Password accettabile!");
        }
        else
        {
            Console.WriteLine("Password NON accettabile!");
        }

        //ESERCIZIO 5 FOREACH
        Console.WriteLine("Inserisci una frase: ");
        string frase4 = Console.ReadLine();
        
        int countCar = 0, countSpazi = 0, countSegni = 0, countPar = 0;
        string[] parole = frase4.Split(' ');

        foreach (var parola in parole)
        {
            countPar++;
        }

        foreach (char carattere in frase4)
        {
            if(char.IsLetter(carattere))
            {
                countCar++;
            }
        }

        foreach (char carattere in frase4)
        {
            if(char.IsWhiteSpace(carattere))
            {
                countSpazi++;
            }
        }

        foreach (char carattere in frase4)
        {
            if(char.IsPunctuation(carattere))
            {
                countSegni++;
            }
        }

        Console.WriteLine($"numero parole: {countPar}");
        Console.WriteLine($"numero caratteri: {countCar}");
        Console.WriteLine($"numero spazi: {countSpazi}");
        Console.WriteLine($"numero segni punteggiatura: {countSegni}");
    }
}