using System;

class Metodi
{
    static string nome = "Marco";
    public static void Main(string[] args)
    {
        Saluta(nome);        
        
        Console.Write("inserisci un numero: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("inserisci un numero: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write($"la somma tra {n1} e {n2} è uguale a: {Somma(n1, n2)}");
    }

    public static int Somma(int a, int b)
    {
        int risultato = a + b;
        return risultato;
    }

    public static void Saluta(string nome)
    {
        Console.Write($"Buongiorno {nome}, come va?\n");
    }
}