using System;

class Cicli_pt2
{
    public static void Main(string[] args)
    {
        bool continua = true;
        int cont = 0;
        do
        {
            Console.WriteLine("Ciclo in esecuzione");            
            cont++;
            if(cont >= 3)
            {
                continua = false;
            }
        }
        while (continua);


        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }
    }
}