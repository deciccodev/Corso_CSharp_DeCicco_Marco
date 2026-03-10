using System;
public class Program
{
    public static void Main(string[] args)
    {
        ConfigurazioneSistema modA = ConfigurazioneSistema.Instance;
        ConfigurazioneSistema modB = ConfigurazioneSistema.Instance;

        List<IDispositivo> dispositivi = new List<IDispositivo>();

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\n=== MENU PRINCIPALE ===");
            Console.WriteLine("[1] Usa Modulo A");
            Console.WriteLine("[2] Usa Modulo B");
            Console.WriteLine("[3] Mostra configurazioni");
            Console.WriteLine("[4] Mostra oggetti");
            Console.WriteLine("[5] Esci");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.WriteLine("\n--- MODULO A ---");
                    MenuConfigurazione(modA, dispositivi);
                    break;

                case "2":
                    Console.WriteLine("\n--- MODULO B ---");
                    MenuConfigurazione(modB, dispositivi);
                    break;

                case "3":
                    config.StampaTutte();
                    break;

                case "4":
                    if (dispositivi.Count == 0){Console.WriteLine("Non sono presenti oggetti in lista!");}
                    else
                    {
                        Console.WriteLine($"Stampa di tutti gli oggetti presenti:");
                        foreach (var v in dispositivi)
                        {
                            Console.WriteLine($"{v}");
                        }
                    }
                    break;
                
                case "5":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }

    public static void MenuConfigurazione(ConfigurazioneSistema config, List<IDispositivo> lista)
    {
        Console.WriteLine("\n=== Scegli configurazione ===");
        Console.WriteLine("[1] Aggiungi Configurazione Computer");
        Console.WriteLine("[2] Aggiungi Configurazione Stampanti");
        Console.WriteLine("[3] Crea Oggetto");

        int moduloScelto = 0;
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                Console.WriteLine("Inserisci chiave configurazione");
                string chiavePc = Console.ReadLine();
                config.Imposta(chiavePc, "computer");
                Console.WriteLine("Configurazione Inserita!");
                break;

            case "2":
                Console.WriteLine("Inserisci chiave configurazione");
                string chiaveStamp = Console.ReadLine();
                config.Imposta(chiaveStamp, "stampante");
                Console.WriteLine("Configurazione Inserita!");
                break;

            case "3":
                Console.WriteLine("\nInserisci la chiave da usare:");
                string chiave = Console.ReadLine();

                string tipo = config.Leggi(chiave);

                if (tipo != null)
                {
                    Creator creator = null;

                    switch (tipo.ToLower())
                    {
                        case "computer":
                            creator = new ModuloA();
                            break;

                        case "stampante":
                            creator = new ModuloB();
                            break;

                        default:
                            Console.WriteLine("Tipo di dispositivo non valido.");
                            return;
                    }

                    if (creator != null)
                    {
                        IDispositivo dispositivo = creator.CreaDispositivo(tipo);

                        if (dispositivo != null)
                        {
                            lista.Add(dispositivo);
                            /*dispositivo.Avvia();
                            dispositivo.MostraTipo();*/
                        }
                        else
                        {
                            Console.WriteLine("Il modulo scelto non può creare questo dispositivo.");
                        }
                    }
                }
                break;

            default:
                Console.WriteLine("Configurazione non valida");
                return;
        }
    }
}