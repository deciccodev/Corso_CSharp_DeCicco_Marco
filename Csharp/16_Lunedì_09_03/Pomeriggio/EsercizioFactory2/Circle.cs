public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Disegno una forma di tipo: {GetType()}\n");
    }
}