using System;

class Esercizi
{
    public static void Main(string[] args)
    {
        //InserisciStampaLista();
        //GeneraListaCasuale();
        OridinamentoLista();

    }

    public static void InserisciStampaLista()
    {
        List<int> numeri = new List<int>();
        bool continua = true;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Inserisci numero interi: ");
            int input = int.Parse(Console.ReadLine());
            numeri.Add(input);
        }

        while (continua)
        {
            Console.Write("Che numero vuoi rimuovere?: ");
            int rimuovi = int.Parse(Console.ReadLine());
            numeri.Remove(rimuovi);

            Console.Write("Vuoi rimuovere altri numeri (true/false)?: ");
            continua = bool.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numeri presenti in lista: ");
        foreach (int n in numeri)
        {
            Console.Write($"{n}, ");
        }
    }

    public static void GeneraListaCasuale()
    {
        List<int> numeri = new List<int>(), numeriPari = new List<int>();
        Random random = new Random();
        int countPari = 0;

        for (int i = 0; i < 10; i++)
        {
            numeri.Add(random.Next(1, 101));
        }

        Console.WriteLine("\nNumeri presenti in lista");
        foreach (int n in numeri)
        {
            Console.Write($"{n}, ");
            if(n % 2 == 0)
            {
                countPari++;
                numeriPari.Add(n);
            }
        }

        Console.Write("Che numero vuoi cercare?: ");
        int ricerca = int.Parse(Console.ReadLine());

        if (numeri.Contains(ricerca))
        {
            Console.WriteLine($"il numero inserito si trova in posizione {numeri.IndexOf(ricerca)}");
        }
        else{Console.WriteLine("Il numero ricercato non è presente in lista!");}

        Console.WriteLine($"Nella lista ci sono {countPari} numeri pari, e sono:");
        foreach (int num in numeriPari)
        {
            Console.Write($"{num}, ");
        }
    }

    public static void OridinamentoLista()
    {
        List<int> numeri = new List<int>(), numeriDuplicati = new List<int>();
        Random random = new Random();

        for (int i = 0; i < 15; i++)
        {
            numeri.Add(random.Next(1, 21));
        }

        Console.WriteLine("-------- STAMPA LISTA ORIGINALE --------");
        foreach (int n in numeri)
        {
            Console.Write($"{n} \t");
        }

        for (int i = 0; i < numeri.Count; i++)
        {
            if (!numeriDuplicati.Contains(numeri[i]))
            {
                numeriDuplicati.Add(numeri[i]);
            }
        }

        numeri.Clear();
        numeri = numeriDuplicati;

        //BUBBLE SORT
        for (int i = 0; i < numeri.Count - 1; i++)
        {
            for (int j = 0; j < numeri.Count - 1 - i; j++)
            {
                if (numeri[j] > numeri[j + 1])
                {
                    int temp = numeri[j];
                    numeri[j] = numeri[j + 1];
                    numeri[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\n-------- STAMPA LISTA SENZA DUPLICATA ED ORDINATA --------");
        foreach (int x in numeri)
        {
            Console.Write($"{x} \t");
        }
    }
}