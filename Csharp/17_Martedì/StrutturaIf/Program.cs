using System;

class StrutturaIf
{
    static void Main(string[] args)
    {
        int a = 15, b = 10;

        if(a > b) //se la condizione è True (verificata), le condizioni sotto l'If vengono eseguite
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }

        else
        {
            //viene eseguito se la condizione nell'if è falsa
            Console.WriteLine($"{a} è minore di {b}");
        }
    }
}