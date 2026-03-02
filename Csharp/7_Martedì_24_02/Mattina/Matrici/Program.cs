using System;

class Matrici
{
    static int[,] matrice = new int[3,3];

    static int nRighe = matrice.GetLength(0); // prende le righe
    static int nColonne= matrice.GetLength(1); // prende le colonne
    
    public static void main(String[] args)
    {
        
    }

    //Assegnazione valori matrice
    public static void ModificaMatrice()
    {
        for (int i = 0; i < nRighe; i++)
        {
            for (int j = 0; j < nColonne; j++)
            {
                matrice[i, j] = (i + j + 1) * 10;
                Console.WriteLine($"Cella Matrice[{i}, {j}] = {matrice[i, j]}");
            }
        }
    }

    //MATRICE INVERTITA
    public static void StampaMatriceInvertita()
    {
        for (int i = nRighe - 1; i >= 0; i--)
        {
            for (int j = nColonne - 1; j >= 0; j--)
            {
                Console.WriteLine($"Cella Matrice[{i}, {j}] = {matrice[i, j]}");
            }
        }
    }

    //ESPLORAZIONE PRIMA DIAGONALE
    public static void CalcolaPrimaDiagonale()
    {
        int somma = 0;
        for (int i = 0; i < nRighe; i++)
        {
            for (int j = 0; j < nColonne; i++)
            {
                if(i == j)
                {
                    somma += matrice[i, j];
                }
            }
        }
        Console.WriteLine($"Somma Prima Diagonale: {somma}");
    }

    //ESPLORAZIONE SECONDA DIAGONALE
    public static void CalcolaSecondaDiagonale()
    {
        int somma = 0;
        for (int i = 0; i < nRighe; i++)
        {
            somma += matrice[i, nColonne - i - 1];
        }
        Console.WriteLine($"Somma Seconda Diagonale: {somma}");
    }

    //RIEMPIMENTO MATRICE RANDOM
    public static void RiempiRandom()
    {
        int[,] randomArray = new int[10,10];
        Random random = new Random();
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            for (int j = 0; j < randomArray.GetLength(1); i++)
            {
                randomArray[i, j] = random.Next(100);
                Console.WriteLine($"random cella {i} {j} = {randomArray[i, j]}");
            }
        }
    }

    //RIEMPIMENTO MATRICE DOUBLE RANDOM
    public static void RiempiRandomDouble()
    {
        double[,] randomArrayDouble = new double[10,10];
        int min = 10, max = 100;
        Random random = new Random();
        for (int i = 0; i < randomArrayDouble.GetLength(0); i++)
        {
            for (int j = 0; j < randomArrayDouble.GetLength(1); i++)
            {
                randomArrayDouble[i, j] = random.NextDouble() * (max - min) + min;
                Console.WriteLine($"Random Double cella {i} {j} = {randomArrayDouble[i, j]:F2}"); //la dicitura :F2 serve a limitare i decimali dopo la virgola a 2 numeri
            }
        }
    }
}