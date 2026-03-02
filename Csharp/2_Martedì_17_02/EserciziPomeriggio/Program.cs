using System;
using System.Reflection;

class EserciziPomeriggio
{
    const int PASSWORD = 123;
    public static void Main(string[] args)
    {
        //ESERCIZIO 1
        /*Console.Write("inserisci un numero intero: ");
        int numero = int.Parse(Console.ReadLine());

        if(numero % 2 == 0)
        {
            Console.Write("il numero inserito è pari!");
        }

        else
        {
            Console.Write("il numero inserito è dispari!");
        }*/


        //ESERCIZIO 2
        /*Console.Write("inserisci una password numerica: ");
        int pass = int.Parse(Console.ReadLine());

        if(pass == PASSWORD)
        {
            Console.WriteLine("Accesso consentito");
        }

        else
        {
            Console.WriteLine("Accesso negato");
        }*/


        //ESERCIZIO 3
        /*Console.Write("inserisci un numero double: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("inserisci un altro numero double: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("inserisci l'operatore + o - : ");
        string operatore = Console.ReadLine();

        if(operatore == "+")
        {
            double sum = num1 + num2;
            Console.Write($"la somma dei numeri è: {sum}");
        }

        else if(operatore == "-")
        {
            double sum = num1 - num2;
            Console.Write($"la sottrazione dei numeri è: {sum}");
        }

        else
        {
            Console.Write("Operatore non valido");
        }*/

        //ESERCIZI IF-ELSE 1
        /*Console.Write("inserisci un voto da 1 a 10: ");
        int valutazione = int.Parse(Console.ReadLine());

        if (valutazione <= 4)
        {
            Console.Write("Insufficiente");
        }
        else if (valutazione <= 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if (valutazione <= 8)
        {
            Console.WriteLine("Buono");
        }
        else
        {
            Console.WriteLine("Ottimo");
        }*/


        //ESERCIZI IF-ELSE 2
        /*Console.Write("inserisci il peso in kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("inserisci l'altezza in metri: ");
        double altezza = double.Parse(Console.ReadLine());

        double bmi = peso / (altezza * altezza);

        if(bmi < 18.5)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Sottopeso");
        }
        else if(bmi < 25)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Normopeso");
        }
        else if(bmi < 30)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Sovrappeso");
        }
        else if(bmi >= 30)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, Obesità");
        }*/


        //ESERCIZI IF-ELSE Extra
        /*Console.Write("inserisci il valore da convertire: ");
        double valore = double.Parse(Console.ReadLine());

        Console.Write("inserisci in cosa vuoi convertire il valore (scegli tra fahrenheit, kelvin, rankine): ");
        string conversione = Console.ReadLine();

        if(conversione == "fahrenheit")
        {
            double tmp_fahrenheit = (valore * 0.8d) + 32;
            Console.Write($"il valore è stato convertito in gradi fahrenheit: {tmp_fahrenheit}");
        }
        else if(conversione == "kelvin")
        {
            double tmp_kelvin = valore + 273.15d;
            Console.Write($"il valore è stato convertito in gradi kelvin: {tmp_kelvin}");
        }
        else if(conversione == "rankine")
        {
            double tmp_rankine = (valore * 1.8d) + 491.67d;
            Console.Write($"il valore è stato convertito in gradi rankine: {tmp_rankine}");
        }*/


        //ESERCIZIO SWITCH 1
        /*Console.WriteLine("inserisci un numero da 1 a 7: ");
        string giorno = Console.ReadLine();

        switch (giorno)
        {
            case "1":
                Console.WriteLine("Lunedì");
                break;
            case "2":
                Console.WriteLine("Martedì");
                break;
            case "3":
                Console.WriteLine("Mercoledì");
                break;
            case "4":
                Console.WriteLine("Giovedì");
                break;
            case "5":
                Console.WriteLine("Venerdì");
                break;
            case "6":
                Console.WriteLine("Sabato");
                break;
            default:
                Console.WriteLine("Lunedì");
                break;
        }*/


        //ESERCIZIO SWITCH 2
        /*Console.WriteLine("Scrivi quale figura vuoi calcolare tra quadrato, cerchio e triangolo:");
        string figura = Console.ReadLine();

        switch (figura)
        {
            case "quadrato":
                Console.WriteLine("inserisci il valore del lato per calcolare l'area del quadrato:");
                double lato = double.Parse(Console.ReadLine());
                double areaQ = lato * lato;
                Console.WriteLine("l'area del quadrato è: " + areaQ);
                break;
            case "cerchio":
                Console.WriteLine("inserisci il valore del raggio per calcolare l'area del cerchio:");
                double raggio = double.Parse(Console.ReadLine());
                double areaC = 3.14d * (raggio * raggio);
                Console.WriteLine("l'area del cerchio è: " + areaC);
                break;
            default:
                Console.WriteLine("inserisci il valore della base per calcolare l'area del triangolo:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("inserisci il valore dell'altezza per calcolare l'area del triangolo:");
                double h = double.Parse(Console.ReadLine());
                double areaT = b * h;
                Console.WriteLine("l'area del triangolo è: " + areaT);
                break;
        }*/


        //ESERCIZIO SWITCH EXTRA
        Console.WriteLine("inserisci un numero intero per determinare se sia pari o dispari:");
        int num = int.Parse(Console.ReadLine());
        string risultato = "";
        if (num % 2 == 0)
        {
            risultato = "pari";
        }
        
        switch (risultato)
        {
            case "pari":
                if(num > 10)
                {
                    Console.WriteLine("il numero è pari e maggiore di 10!");
                }
                else
                {
                    Console.WriteLine("il numero è pari e minore di 10!");
                }
                break;
            default:
                if(num > 10)
                {
                    Console.WriteLine("il numero è dispari e maggiore di 10!");
                }
                else
                {
                    Console.WriteLine("il numero è dispari e minore di 10!");
                }
                break;
        }
    }
}