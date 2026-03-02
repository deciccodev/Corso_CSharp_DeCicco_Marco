using System;

// commento linea singola
class Program
{    
    public static readonly string Nome = "Pino";
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");

        #region VARIABILI E CASTING
        int numero = 10;
        float decimaleFloat = 3.14f;
        double decimaleDouble = 3.14d;
        char lettera = 'A';
        bool condizione = true;
        string saluto = "Ciao a tutti!";
        
        const float VAR_CONST = 3.14f;

        //Casting Implicito (safe, non perdita di dati)
        int intero = 42;
        float numeroLungo = intero + 0.5f;

        //Casting Esplicito (potenziale perdita / eccezione)
        float pi = 3.14f;
        int circaPi = (int)pi;
        
        //stampa dei valori delle variabili assegnate
        Console.WriteLine("Numero = " + numero);
        Console.WriteLine("Decimale float = " + decimaleFloat + "f");
        Console.WriteLine("Decimale double = " + decimaleDouble + "d");
        Console.WriteLine("Lettera = " + lettera);
        Console.WriteLine("Condizione = " + condizione);
        Console.WriteLine("Saluto = " + saluto);
        Console.WriteLine("Var Constante = " + VAR_CONST);
        Console.WriteLine("Ciao  mi chiamo " + Nome);
        Console.WriteLine("Casting Implicito = " + numeroLungo);
        Console.WriteLine("Casting Esplicito = " + circaPi);
        #endregion

        #region INPUT E CONVERSIONI STRINGHE
        //esempio stringa
        Console.Write("Come ti chiami?");
        string nome_Input = Console.ReadLine();
        Console.Write($"Ciao {nome_Input}!\n");

        //CONVERSIONE STRINGA - NUMERO
        Console.Write("Dammi un numero? ");
        string n1 = Console.ReadLine();
        Console.Write("Dammi un altro numero? ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1);
        int numero2 = int.Parse(n2);

        Console.WriteLine($"Somma di {numero1} + {numero2} = {numero1 + numero2}");
        #endregion*/

        #region OPERATORI
        int a = 10;
        int b = 7;

        Console.WriteLine("Operatori aritmetici: ");
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Addizione: a + b = {a + b}");
        Console.WriteLine($"Sottrazione: a - b = {a - b}");
        Console.WriteLine($"Moltiplicazione: a * b = {a * b}");
        Console.WriteLine($"Divisione: a / b = {a / b}");
        Console.WriteLine($"Modulo (resto): a % b = {a % b}\n");
        Console.WriteLine($"Operatori Assegnamento:");
        Console.WriteLine($"Incremento: a++ = {a++}");
        Console.WriteLine($"Ora a = {a}");
        Console.WriteLine($"Decremento: b-- = {b--}");
        Console.WriteLine($"Ora b = {b}\n");

        int x = 10;
        int y = 15;
        Console.WriteLine("Operatori Logici:");
        Console.WriteLine($"AND: {x < y && x >= 10}");
        Console.WriteLine($"OR: {x > y || x >= 10}");
        Console.WriteLine($"NOT: {!(x < y)}");    
        #endregion
    }
}

/* commento a blocco */

///<summary>
///commento XML
///<summary>