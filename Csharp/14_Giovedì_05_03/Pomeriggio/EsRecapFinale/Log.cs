public class Log
{
    private List<string> _logs = new List<string>();

    public void AggiungiLog(Persona persona, string action)
    {
        string log = action + " -> " + persona;

        if(_logs.Count > 10) {_logs.RemoveAt(0);}

        _logs.Add(log);
    }

    public void MostraLog()
    {
        Console.WriteLine("Lista delle ultime 10 operazioni eseguite:");

        foreach (var l in _logs)
        {
            Console.WriteLine(l);
        }
    }
}