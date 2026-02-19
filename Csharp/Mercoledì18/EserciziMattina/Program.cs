using System;

class EserciziMattina
{
    public static void Main(string[] args)
    {
        const int PASS = 123;
        int cont = 2, sum = 0, num = 0, cont2 = 0;
        bool continua = true;


        //ESERCIZIO DO-WHILE 1
        /*do
        {
            Console.Write("Inserisci la password numerica: ");
            int pass = int.Parse(Console.ReadLine());
            if (pass == PASS || cont == 0)
            {
                break;
            }
            else
            {
                cont--;
                Console.WriteLine($"Tentativi rimasti: {cont + 1}");
            }
        }
        while (cont >= 0);*/


        //ESERCIZIO DO-WHILE 2
        /*do
        {
            Console.Write("Inserisci un numero intero (inserire 0 per uscire): ");
            num = int.Parse(Console.ReadLine());
            
            sum += num;

            if(num == 0)
            {
                Console.Write($"Sono stati inseriti {cont2} numeri e la somma totale è: {sum}");
            }
            cont2 ++;
        }
        while (num != 0);*/


        //ESERCIZIO DO-WHILE 3
        /*do
        {
            Console.Write("Inserisci un numero intero: ");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.Write("Inserisci un altro numero intero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("\nInserisci quale operazione eseguire tra i due numeri: \n1.+ \n2.- \n3.* \n4/ \n");
            string operazione = Console.ReadLine();

            switch (operazione)
            {
                case "+":
                    sum = n1 + n2;
                    Console.Write($"\nLa somma tra i due numeri è: {sum}\n");
                    break;
                case "-":
                    sum = n1 - n2;
                    Console.Write($"\nLa sottrazione tra i due numeri è: {sum}\n");
                    break;
                case "*":
                    sum = n1 * n2;
                    Console.Write($"\nLa moltiplicazione tra i due numeri è: {sum}\n");
                    break;
                case "/":
                    sum = n1 / n2;
                    Console.Write($"\nLa divisione tra i due numeri è: {sum}\n");
                    break;
                default:
                    Console.Write("Operazione non consentita\n");
                    break;
            }

            Console.Write("Vuoi fare un'altra operazione? (True o False) ");
            continua = bool.Parse(Console.ReadLine());
        }
        while (continua);*/


        //ESERCIZIO FOR 1
        /*Console.Write("Inserisci un numero intero: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"La tabellina di {n1} è:");
        for (int i = 1; i <= 10; i++)
        {          
            Console.WriteLine($"{n1 * i}");
        }*/


        //ESERCIZIO FOR 2
        /*Console.Write("Quanti numeri vuoi inserire? ");
        cont = int.Parse(Console.ReadLine());

        for (int i = 0; i < cont; i++)
        {
            Console.Write("Inserisci il numero: ");
            int tmp = int.Parse(Console.ReadLine());
            sum += tmp; 
        }

        Console.Write($"La media è: {sum / cont}");*/


        //ESERCIZIO FOR 3
        Console.Write("Inserisci un numero intero positivo: ");
        int intero = int.Parse(Console.ReadLine());

        if(intero <= 0)
        {
            Console.Write("Errore: numero minore o uguale a 0");
        }
        else
        {
            for (int i = intero - 1; i > 0; i--)
            {
                intero *= i;
            }
            Console.Write($"Il fattoriale è: {intero}");          
        }
    }
}