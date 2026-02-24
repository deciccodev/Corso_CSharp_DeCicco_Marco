using System;

class Esercizi
{
    static void Main(string[] args)
    {
        //esercizio 1
        /*Console.Write("inserisci un intero: ");
        string n1 = Console.ReadLine();
        Console.Write("\ninserisci un intero: ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1);
        int numero2 = int.Parse(n2);

        Console.WriteLine($"la somma dei due numeri e': {numero1 + numero2}");


        //esercizio 2
        Console.Write("inserisci il prezzo: ");
        string p1 = Console.ReadLine();

        double prezzo1 = double.Parse(p1);
        prezzo1 *= 0.8d;
        Console.WriteLine($"il prezzo scontato e'': {prezzo1}");


        //esercizio 3
        Console.Write("verifica numero positivo: ");
        string x1 = Console.ReadLine();

        float pos1 = float.Parse(x1);

        Console.WriteLine($"il numero {pos1} e' positivo': {pos1 >= 0}");*/


        //esercizio 4
        /*Console.Write("inserisci un numero intero: ");
        string n1 = Console.ReadLine();
        Console.Write("\ninserisci un numero con la virgola: ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1);
        float numero2 = float.Parse(n2);

        float numero3 = numero2 + numero1;

        Console.WriteLine($"la somma dei due numeri e': {numero3}");*/


        //esercizio 5
        /*Console.Write("inserisci la tua eta': ");
        string e = Console.ReadLine();
        Console.Write("\ninserisci la tua altezza in metri: ");
        string a = Console.ReadLine();

        int eta = int.Parse(e);
        float altezza = float.Parse(a);

        int castA = (int)altezza;
        int somma = eta + castA;

        Console.WriteLine($"la somma dell'eta' e dell'altezza e': {somma}");*/


        //esercizio extra - 6
        /*Console.Write("inserisci un numero: ");
        string k1 = Console.ReadLine();
        Console.Write("\ninserisci un altro numero: ");
        string k2 = Console.ReadLine();

        int tmp1 = int.Parse(k1);
        int tmp2 = int.Parse(k2);

        Console.WriteLine($"il primo numero ed il secondo sono positivi? {tmp1 > 0 && tmp2 > 0} \nuno dei due numeri e' positivo? {tmp1 > 0 || tmp2 > 0} \nil primo numero e' positivo? {!(tmp1 < 0)}");*/


        //esercizio if - 1
        /*Console.Write("inserisci la tua eta': ");
        int eta = int.Parse(Console.ReadLine());
        
        if(eta >= 18)
        {
           Console.Write($"la tua eta' e' {eta}, sei maggiorenne! "); 
        }*/


        //esercizio if - 2
        /*Console.Write("inserisci il prezzo del prodotto: ");
        float prezzoProdotto = float.Parse(Console.ReadLine());

        if(prezzoProdotto > 100)
        {
            Console.Write($"il prezzo del prodotto dopo lo sconto del 10% applicato e' di: {prezzoProdotto * 0.9f}.");
        }

        else
            Console.Write($"il prodotto non è stato scontato in quanto il prezzo è di: {prezzoProdotto} euro.");*/


        //esercizio extra - if
        /*Console.Write("inserisci il primo numero: ");
        int primo = int.Parse(Console.ReadLine());

        Console.Write("inserisci il secondo numero: ");
        int secondo = int.Parse(Console.ReadLine());

        Console.Write("inserisci il terzo numero: ");
        int terzo = int.Parse(Console.ReadLine());

        double somma = (double)(primo + secondo + terzo);
        double media = somma / 3;

        if(media >= 60)
        {
            Console.Write($"Hai superato la prova! la media è uguale a: {media}");
        }

        else
            Console.Write($"Prova fallita... la media è uguale a: {media}");*/


        //esercizio extra 2 - if
        Console.Write("inserisci il primo numero: ");
        float primo = float.Parse(Console.ReadLine());

        Console.Write("inserisci il secondo numero: ");
        float secondo = float.Parse(Console.ReadLine());

        //controllo AND
        if(primo > 10 && secondo > 10)
        {
            Console.Write("entrambi i numeri sono maggiori di 10!\n");
        }

        //controllo OR
        if(primo > 10 || secondo > 10)
        {
            Console.Write("almeno un numero è maggiore di 10!\n");
        }

        //controllo NOT
        if(!(primo < 10))
        {
            Console.Write("il primo numero è maggiore di 10!");
        }
    }
}