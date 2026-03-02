using System;

class Esercizi
{
    public static void Main(string[] args)
    {
        //IndovinaRandom();
        //LancioDadi();
        //Temperatura();
        //CalcolaMatrice();
        DoppiaMatriceRandom();
        //StampaSommaDiagonale();
        
        //ESERCIZI EXTRA
        //StampaVoti();
        //StampaSommaArray();
        //StampaRandomArray();
    }

    public static void IndovinaRandom()
    {
        Random random = new Random();
        int numeroRandom = random.Next(1, 11);

        Console.Write($"Indovina il numero random tra i e 10!: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Il numero random era: " + numeroRandom);
        if (input == numeroRandom){Console.WriteLine("Hai indovinato!");}
        else{Console.WriteLine("Mi spiace, riprova!");}        
    }

    public static void LancioDadi()
    {
        Random random = new Random();
        int dado1 = random.Next(1, 7), dado2 = random.Next(1, 7), somma = 0;

        Console.WriteLine($"Sul primo dado è uscito: {dado1}");
        Console.WriteLine($"Sul secondo dado è uscito: {dado2}");
        somma = dado1 + dado2;
        Console.WriteLine($"La somma dei due lanci è: {somma}");        
    }

    public static void Temperatura()
    {
        int minTemp = 0, maxTemp = 40;
        float media = 0;

        Console.Write($"Quanti giorni vuoi simulare? ");
        int input = int.Parse(Console.ReadLine());

        int[] temperature = new int[input];

        for (int i = 0; i < input; i++)
        {
            Random random = new Random();
            int numeroRandom = random.Next(minTemp, maxTemp + 1);
            media += numeroRandom;
            temperature[i] = numeroRandom;
        }

        Console.WriteLine($"La temperatura minima era {minTemp}");
        Console.WriteLine($"La temperatura massima era {maxTemp}");
        Console.WriteLine($"Le temperature generate sono: ");
        for (int i = 0; i < input; i++)
        {
            Console.Write(temperature[i] + ", ");
        }
        Console.WriteLine($"\nLa temperatura media è: {media / input}");
    }

    public static void CalcolaMatrice()
    {
        Console.Write("Inserisci il numero di righe: ");
        int righe = int.Parse(Console.ReadLine());

        Console.Write("Inserisci il numero di colonne: ");
        int colonne = int.Parse(Console.ReadLine());

        int[,] matrice = new int[righe, colonne];

        //---------- RIEMPIMENTO MATRICE ----------
        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                matrice[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nSomma righe:");
        for (int i = 0; i < righe; i++)
        {
            int sommaRiga = 0;
            for (int j = 0; j < colonne; j++)
            {
                sommaRiga += matrice[i, j];
            }
            Console.WriteLine($"Somma riga {i + 1}: {sommaRiga}");
        }

        Console.WriteLine("\nSomma colonne:");
        for (int j = 0; j < colonne; j++)
        {
            int sommaColonna = 0;
            for (int i = 0; i < righe; i++)
            {
                sommaColonna += matrice[i, j];
            }
            Console.WriteLine($"Somma colonna {j + 1}: {sommaColonna}");
        }
    }

    public static void DoppiaMatriceRandom()
    {
        int[,] matrice1 = new int[4,4]; 
        int [,] matrice2 = new int[4,4];
        int piuMatrice1 = 0, piuMatrice2 = 0, pareggi = 0;
        Random random = new Random();

        //RIEMPIMENTO MATRICI
        for (int i = 0; i < matrice1.GetLength(0); i++)
        {
            for (int j = 0; j < matrice1.GetLength(1); j++)
            {
                matrice1[i, j] = random.Next(1, 51);
                matrice2[i, j] = random.Next(1, 51);
            }
        }

        Console.WriteLine("\n------------- Stampa Matrice 1: -------------");
        for (int i = 0; i < matrice1.GetLength(0); i++)
        {
            for (int j = 0; j < matrice1.GetLength(1); j++)
            {
                Console.Write($"{matrice1[i, j],6}");
            }
            Console.Write("\n");
        }

        Console.WriteLine("\n------------- Stampa Matrice 2: -------------");
        for (int i = 0; i < matrice2.GetLength(0); i++)
        {
            for (int j = 0; j < matrice2.GetLength(1); j++)
            {
                Console.Write($"{matrice2[i, j],6} ");
            }
            Console.Write("\n");
        }

        for (int i = 0; i < 4; i++)
        {
            int somma1 = 0;
            int somma2 = 0;

            for (int j = 0; j < 4; j++)
            {
                somma1 += matrice1[i, j];
                somma2 += matrice2[i, j];
            }

            if (somma1 > somma2){piuMatrice1++;}
            else if (somma2 > somma1){piuMatrice2++;}
            else{pareggi++;}
        }

        Console.WriteLine("\n--- RISULTATO FINALE ---");
        Console.WriteLine($"Matrice 1 vince {piuMatrice1} confronti");
        Console.WriteLine($"Matrice 2 vince {piuMatrice2} confronti");
        Console.WriteLine($"Pareggi: {pareggi}");

        if (piuMatrice1 > piuMatrice2)
            Console.WriteLine("La Matrice 1 ha più righe vincenti.");
        else if (piuMatrice2 > piuMatrice1)
            Console.WriteLine("La Matrice 2 ha più righe vincenti.");
        else
            Console.WriteLine("Le due matrici pareggiano nel numero di righe vincenti.");
        }

    public static void StampaSommaDiagonale()
    {
        int[,] matrice = new int[5,5];
        int sommaDiagonalePrincipale = 0, sommaDiagonaleSecondaria = 0;
        Random random = new Random();

        //RIEMPIMENTO MATRICE
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                matrice[i, j] = random.Next(1, 51);
            }
        }

        Console.WriteLine("\n------------- Stampa Matrice: -------------");
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                Console.Write($"{matrice[i, j],6} ");
            }
            Console.Write("\n");
        }

        //CALCOLO PRIMA DIAGONALE
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                if(i == j)
                {
                    sommaDiagonalePrincipale += matrice[i, j];
                }
            }
        }
        Console.WriteLine($"Somma Prima Diagonale: {sommaDiagonalePrincipale}");

        //CALCOLO SECONDA DIAGONALE
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            sommaDiagonaleSecondaria += matrice[i, matrice.GetLength(1) - i - 1];
        }
        Console.WriteLine($"Somma Seconda Diagonale: {sommaDiagonaleSecondaria}");

        if (sommaDiagonalePrincipale > sommaDiagonaleSecondaria){Console.WriteLine($"La somma della diagonale maggiore è la principale che è uguale a: {sommaDiagonalePrincipale}");}
        else if (sommaDiagonalePrincipale < sommaDiagonaleSecondaria){Console.WriteLine($"La somma della diagonale maggiore è la secondaria che è uguale a: {sommaDiagonaleSecondaria}");}
        else{Console.WriteLine($"La somma delle diagonali è uguale");}
    }

    
    
    #region ESERCIZI EXTRA
    public static void StampaVoti()
    {
        int[] voti = new int[5];
        int votoMin = 9999, votoMax = 0;
        float media = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"min: {votoMin}, max: {votoMax}");
            Console.Write("Inserisci il voto (int): ");
            voti[i] = int.Parse(Console.ReadLine());
            if(votoMin > voti[i]){votoMin = voti[i];}
            if(votoMax < voti[i]){votoMax = voti[i];}
            media += voti[i];
        }

        Console.WriteLine($"Il voto più basso è: {votoMin}");
        Console.WriteLine($"Il voto più alto è: {votoMax}");
        Console.WriteLine($"La media voti è: {media / 5}");
    }
    
    public static void StampaSommaArray()
    {
        Console.WriteLine("quanti numeri interi vuoi inserire?");
        int dimensione = int.Parse(Console.ReadLine());

        int[] array = new int[dimensione];
        int somma = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Inserisci numero: ");
            array[i] = int.Parse(Console.ReadLine());
            somma += array[i];
        }

        Console.Write($"La somma dei numeri inseriti è: {somma}");
    }
    

    public static void StampaRandomArray()
    {
        int[] array = new int[10];
        Random random = new Random();
        int min = 9999, max = 0;

        //RIEMPIMENTO ARRAY
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
            if(min > array[i]){min = array[i];}
            if(max < array[i]){max = array[i];}
        }

        //STAMPA ARRAY
        Console.WriteLine("Numeri random nell'array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine($"\nNumero minore nell'array: {min}");
        Console.WriteLine($"Numero maggiore nell'array: {max}");
    }
    
    #endregion
}