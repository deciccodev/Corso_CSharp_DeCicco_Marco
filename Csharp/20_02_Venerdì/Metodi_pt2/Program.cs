using System;

class Metodi_pt2
{
    public static void Main(string[] args)
    {
        //================== ESERCIZIO 1 ===============================
        int valore = 2;
        Console.WriteLine("il numero prima del raddoppio è: " + valore);
        Raddoppia(ref valore);
        Console.WriteLine("il numero dopo il raddoppio è: " + valore);

        //================== ESERCIZIO 2 ===============================
        int giorno = 30, mese = 12, anno = 3000;
        Console.WriteLine($"data attuale: {giorno} / {mese} / {anno}");
        AggiustaData(ref giorno, ref mese, ref anno);
        Console.WriteLine($"data post aggiornamento: {giorno} / {mese} / {anno}");

        //================== ESERCIZIO 3 ===============================
        Console.Write("Inserisci il primo numero: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il secondo numero: ");
        int n2 = int.Parse(Console.ReadLine());
        float d;
        Dividi(n1, n2, out d);
        Console.Write($"il quoziente tra {n1} e {n2} è: {d}");

        //================== ESERCIZIO 4 ===============================
        Console.Write("Inserisci frase: ");
        string frase = Console.ReadLine();
        int numV, numC, numS;
        AnalizzaParola(frase, out numV, out numC, out numS);
        Console.WriteLine($"nella frase ci sono {numV} vocali, {numC} consonanti, {numS} spazi");

        //================== ESERCIZIO 5 ===============================
        int count = 0;
        int punteggioTotale = 0;
        while (count < 3)
        {
            Console.Write("Inserisci punteggio: ");
            int punteggio = int.Parse(Console.ReadLine());
            Console.Write("Inserisci bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            AggiornaPunteggio(ref punteggio, bonus, ref punteggioTotale);
            count++;
        }
        Console.Write($"la media punteggio è: {punteggioTotale / 3}");
        
        //================== ESERCIZIO 6 ===============================
        double media;
        Console.Write("Inserisci primo voto: ");
        int voto1 = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il bonus al primo voto: ");
        int bonus1 = int.Parse(Console.ReadLine());

        Console.Write("Inserisci secondo voto: ");
        int voto2 = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il bonus al secondo voto: ");
        int bonus2 = int.Parse(Console.ReadLine());

        if(ElaboraStudente(ref voto1, ref voto2, bonus1, bonus2, out media))
        {
            Console.WriteLine($"la media è: {media}, Promosso!");
        }
        else
        {
            Console.WriteLine($"la media è: {media}, Bocciato!");
        }

        //================== ESERCIZIO 7 ===============================
        Console.Write("Inserisci primo numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        
        Console.Write("Inserisci secondo numero: ");
        int numero2 = int.Parse(Console.ReadLine());
        
        Console.Write("Inserisci terzo numero: ");
        int numero3 = int.Parse(Console.ReadLine());

        int minimo, massimo;
        float media7 = AnalizzaSerieDiNumeri(numero1, numero2, numero3, out minimo, out massimo);

        Console.WriteLine($"il numero minimo è: {minimo}, il massimo è: {massimo}, la media dei numeri è: {media}");

        //================== ESERCIZIO 8 ===============================
        int count8 = 0, somma = 0, min = 1000, max = 9999;
        double media8 = 0;
        bool continua = true;

        while (continua)
        {
            Console.Write("Inserisci voto: ");
            int votoInserito = int.Parse(Console.ReadLine());
            AggiornaVoti(votoInserito, ref count8, ref somma, ref min, ref max, ref media8);

            Console.Write("Inserire altri voti?: (true/false) ");
            bool check = bool.Parse(Console.ReadLine());

            if (!check)
            {
                continua = false;
            }
        }

        Console.WriteLine($"statistiche: \ncount {count} \nsomma voti: {somma} \nvoto min: {min} \nvoto max: {max} \nmedia voti: {media}");
    }

    public static void Raddoppia(ref int numero)
    {
        numero *= 2;
    }

    public static void AggiustaData(ref int giorno, ref int mese, ref int anno)
    {
        giorno += 1;
        if (giorno > 30){
            giorno = 1;
            mese += 1;}
        if (mese > 12){
            mese = 1;
            anno += 1;}
    }

    public static void Dividi(int a, int b, out float resto)
    {
        resto = a / b;
    }

    public static void AnalizzaParola(string s, out int nV, out int nC, out int nS)
    {
        string controlloVocali = "aeiou";
        string controlloConsonanti = "bcdfghlmnpqrstvz";
        string risultato = s.ToLower();
        int count = 0;

        foreach (char carattere in risultato)
        {
            if (controlloVocali.Contains(carattere)) { count++; }
        }
        nV = count;
        count = 0;

        foreach (char carattere in risultato)
        {
            if (controlloConsonanti.Contains(carattere)) { count++; }
        }
        nC = count;
        count = 0;

        foreach (char carattere in risultato)
        {
            if (char.IsWhiteSpace(carattere)) { count++; }
        }
        nS = count;
    }

    public static void AggiornaPunteggio(ref int punteggio, int bValore, ref int punTotale)
    {
        punTotale += punteggio + bValore;
    }

    public static bool ElaboraStudente(ref int voto1, ref int voto2, int bonus1, int bonus2, out double media)
    {
        if(bonus1 <= 10)
        {
            voto1 += bonus1;
        }
        else{Console.WriteLine("Errore Bonus");}

        if(bonus2 <= 10)
        {
            voto2 += bonus2;
        }
        else{Console.WriteLine("Errore Bonus");}

        media = (voto1 + voto2) / 2;

        if(media >= 6) {return true;}
        else {return false;}
    }

    public static float AnalizzaSerieDiNumeri(int num1, int num2, int num3, out int min, out int max)
    {
        int media = 0;
        min = num1;
        max = num1;

        if (num1 < min)
        {
            min = num1;
        }
        else if (num2 < min)
        {
            min = num2;
        }
        else if (num3 < min)
        {
            min = num3;
        }
    
        if (num1 > max)
        {
            max = num1;
        }
        else if (num2 > max)
        {
            max = num2;
        }
        else if (num3 > max)
        {
            max = num3;
        }
        media = (num1 + num2 + num3) / 3;
        return media;
    }

    public static bool AggiornaVoti(int votoInserito, ref int count, ref int somma, ref int min, ref int max, ref double media)
    {

        count++;
        somma += votoInserito;
        media = (double)somma / count;
        
        if (votoInserito < 0)
            return false;

        while (votoInserito > 30)
        {
            votoInserito /= 10;
        }

        int decine = votoInserito / 10;
        for (int i = 0; i < decine; i++)
        {
            if (votoInserito < 30)
                votoInserito++;
            else
                break;
        }

        if (count == 1)
        {
            min = votoInserito;
            max = votoInserito;
        }
        else
        {
            if (votoInserito < min)
                min = votoInserito;

            if (votoInserito > max)
                max = votoInserito;
        }

        return true;
    }

}